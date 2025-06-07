using AdventureWorks.Models;
using AdventureWorks.Repositories;
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
    }
}
