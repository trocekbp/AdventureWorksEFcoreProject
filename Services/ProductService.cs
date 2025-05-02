using AdventureWorks.Models;
using AdventureWorks.Repositories;
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
