using AdventureWorks.Models;
using AdventureWorks.Models.DTO;
using AdventureWorks.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services
{ 
    class ProductInventoryService
    {
        private readonly AdventureWorksContext _context;
        private ProductRepository productRepo;
        public ProductInventoryService(AdventureWorksContext context)
        {
            _context = context;
            this.productRepo = new ProductRepository(_context);
        }

        public void EditQuantity(int productID) {

            var inventory = _context.ProductInventories
                                    .Include(loc => loc.Location)
                                    .Where(i => i.ProductID == productID);


            if (inventory == null) {
                 throw new DbUpdateException("Niepowodzenie, nie ma produktu o takim id ! ");
            }

    
            foreach (var item in inventory)
            {
                Console.WriteLine($"Lokalizacja: {item.Location.Name} | Półka: {item.Shelf} | Kosz: {item.Bin} | Obecna ilość: {item.Quantity}");
                Console.Write("Wprowadź nową ilość (ENTER = pomiń): ");
                var input = Console.ReadLine();

                // Jeśli użytkownik nie wpisał nic, pomijamy
                if (string.IsNullOrWhiteSpace(input))
                    continue;

                // Parsujemy nową ilość
                if (short.TryParse(input, out short newQty) && newQty >= 0)
                {
                    if (newQty < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ilość nie może być mniejsza niż zero. Spróbuj ponownie.");
                        Console.ResetColor();
                        continue;   // wracamy do promptu tej samej pozycji
                    }
                    item.Quantity = newQty;  // EF Core „trackuje” tę zmianę
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Niepoprawny format lub ujemna wartość. Pomijam tę pozycję.");
                    Console.ResetColor();
                }
            }

            // 4) Zapis zmian jednym wywołaniem
            _context.SaveChanges();
            Logger.LogOperation($"Zaktualizowano ilości dla produktu {productID} w {inventory.Count()} lokalizacjach.");
        }
        public void ShowProductQuantity(int productID)
        {
            var inventory = _context.ProductInventories
                                   .Include(loc => loc.Location)
                                   .Where(i => i.ProductID == productID);


            if (inventory == null)
            {
                throw new DbUpdateException("Niepowodzenie, nie ma produktu o takim id ! ");
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            foreach (var item in inventory)
            {
                Console.WriteLine($"Lokalizacja: {item.Location.Name} | Półka: {item.Shelf} | Kosz: {item.Bin} | Obecna ilość: {item.Quantity}");
            }
            Console.ResetColor();
        }

        public async Task CriticalStockReportAsync()
        {
            {

                /*
                 SELECT p.ProductID, p.ReorderPoint, SUM(i.Quantity) as TotalQuantity FROM 
                    Production.ProductInventory i
                    join Production.Product p on i.ProductID = p.ProductID
                    GROUP BY p.ProductID, p.ReorderPoint
                    HAVING sum(i.Quantity) < p.ReorderPoint;
                 */
                try
                {
                    var critStock = _context.CriticalStocks
                                        .FromSqlRaw($"SELECT * FROM CriticalStockView"); //pobranie raportu z widoku

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("==Produkty ze stanem poniżej progu ponownego zamówienia==");
                    Console.BackgroundColor = ConsoleColor.Yellow;              
                    foreach (var item in critStock)
                    {
                       
                        Console.WriteLine($"{item.ProductID} | {item.Name} | Próg minimalnego stanu / aktualny stan: {item.ReorderPoint} / {item.TotalQuantity} BRAKUJE: {item.ReorderPoint - item.TotalQuantity}");

                    }
                    Console.ResetColor();
                }
                catch (SqlException sqlEx)
                {
                    // wyjątki z warstwy sterownika ADO.NET (np. błąd składni, timeout)
                    Console.Error.WriteLine("[SQL ERROR] Kod: {0}, Wiadomość: {1}", sqlEx.Number, sqlEx.Message);
                    if (sqlEx.InnerException != null)
                        Console.Error.WriteLine("[INNER] " + sqlEx.InnerException.Message);
                }
                catch (System.InvalidCastException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                    if(ex.InnerException != null)
                        Console.Error.WriteLine(ex.InnerException.Message);

                }
       
            }
        }
    }
}


//TO DO:
// w menu wyświelanie stanów magazynowych dla produktu
// dodawanie ilości dla danego produktu
// raport ilościowy