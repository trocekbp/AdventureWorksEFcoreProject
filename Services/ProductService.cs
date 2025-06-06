using AdventureWorks.Models;
using AdventureWorks.Models.DTO;
using AdventureWorks.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services
{
    class ProductService
    {
        private readonly AdventureWorksContext _context;
        private ProductRepository productRepo;

        public ProductService(AdventureWorksContext context)
        {
            _context = context;
            this.productRepo = new ProductRepository(_context);
        }

        public async Task<int> RegisterProduct(ProductDTO dto) {

            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Nazwa produktu nie może być pusta.");

            else if (dto.ListPrice <= 0)
                throw new ArgumentException("Cena (ListPrice) musi być większa od zera.");

            else if (string.IsNullOrWhiteSpace(dto.ProductNumber))
            {
                var number = await _context.Database
                    .SqlQuery<string>($"SELECT dbo.GenerateProductCode({dto.Name}) AS Value")
                    .FirstAsync();
                dto.ProductNumber = number;
            }


            var product = new Product
            {
                Name = dto.Name,
                ProductNumber = dto.ProductNumber,
                MakeFlag = dto.MakeFlag,
                FinishedGoodsFlag = dto.FinishedGoodsFlag,
                SafetyStockLevel = dto.SafetyStockLevel,
                ReorderPoint = dto.ReorderPoint,
                ListPrice = dto.ListPrice,
                ProductSubcategoryID = dto.ProductSubcategoryID,
                ModifiedDate = DateTime.Now,
                SellStartDate = DateTime.Now
            };

                  // Jeżeli chcemy wymusić powiązanie z kategorią, możemy:
            if (dto.ProductCategoryID.HasValue)
            {
                // Zakładamy, że istnieje ProductSubcategory, a on ma powiązaną kategorię.
                // W modelu AdventureWorks tabela ProductSubcategory zawiera klucz obcy do ProductCategory.
                var subcat = await _context.ProductSubcategories
                    .FirstOrDefaultAsync(ps => ps.ProductSubcategoryID == dto.ProductSubcategoryID);

                if (subcat == null)
                    throw new InvalidOperationException($"Nie ma podkategorii o ID = {dto.ProductSubcategoryID.Value}.");


                product.ProductSubcategoryID = dto.ProductCategoryID;
            }

            // Dodajemy do kontekstu i zapisujemy:
            _context.Products.Add(product);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex) {

                Console.WriteLine("Błąd zapisu do bazy: " + ex.Message);

                // Jeśli istnieje warstwa wewnętrznego wyjątku, wypisz jego treść:
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Szczegóły wewnętrznego wyjątku: " +
                                      ex.InnerException.Message);
                }
                return -1;
            }
            return product.ProductID;
        }
        public List<SalesOrderDetail> GetSalesOrderDetailsList() {
            var product_list = new List<SalesOrderDetail>();
            int id = 0;
            do
            {
                Console.Write("Wprowadź produkt poprzez id produktu (koniec wprowadzania: ID = 0)");
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out id))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawny format ID. Wprowadź liczbę całkowitą.");
                    Console.ResetColor();
                    continue; // wraca do początku pętli
                }

                if (id != 0)
                {
                    Console.WriteLine($"Wprowadzono ID: {id}");
                    var product = productRepo.GetProductById(id);
                    if (product != null)
                    {
                        Console.Write($"Produkt: {product.Name}, cena: {product.ListPrice} | Wprowadź ilość produktów: ");
                        input = Console.ReadLine();
                        if (!short.TryParse(input, out short quantity))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Niepoprawny format. Wprowadź liczbę całkowitą.");
                            Console.ResetColor();
                            continue; // wraca do początku pętli
                        }
                        else
                        {
                            //Dodanie produktu do Listy
                            product_list.Add(new SalesOrderDetail
                            {
                                ProductID = id,
                                OrderQty = quantity,
                                UnitPrice = product.ListPrice,
                                SpecialOfferID = 1

                            });
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Produkt o ID {id} nie został znaleziony.");
                        Console.ResetColor();
                    }
                }

            } while (id != 0);

            return product_list; 
        }
    }
}
