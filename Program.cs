using System;
using AdventureWorks.Models;
using AdventureWorks.Models.DTO;
using AdventureWorks.Repositories;
using AdventureWorks.Services;
using Microsoft.EntityFrameworkCore;



namespace AdventureWorks
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using var context = new AdventureWorksContext();

            // Szybkie sprawdzenie, czy baza jest dostępna
            if (!context.Database.CanConnect())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błąd: nie można połączyć się z bazą danych.");
                Console.ResetColor();
                Logger.LogOperation("Błąd połączenia z bazą danych – brak możliwości połączenia.");
                return;
            }
            ;

            // REPOSITORIES
            var productRepo = new ProductRepository(context);
            var orderRepo = new OrderRepository(context);
            var categoryRepo = new CategoryRepository(context);
            var shipMethodReop = new ShipMethodRepository(context);

            // SERVICES
            var customerService = new CustomerService(context);
            var orderService = new OrderService(context);
            var productService = new ProductService(context);

            //TEST REJESTRACJI PRODUKTU
            // 4) Przygotowanie DTO i wywołanie metody:
            var newProductDto = new ProductDTO
            {
                Name = "Produkt bez DI2",
                MakeFlag = true,
                FinishedGoodsFlag = true,
                SafetyStockLevel = 10,
                ListPrice = 29.99m,
                ProductSubcategoryID = 1,   // zakładamy, że taka podkategoria istnieje
                ProductCategoryID = 1
            };

            try
            {
                var newProductId = await productService.RegisterProduct(newProductDto);
                Console.WriteLine($"Pomyślnie zarejestrowano nowy produkt. ID: {newProductId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }



            while (true)
            {   
                Console.WriteLine("\n=== AdventureWorks Menu ===");
                Console.WriteLine("1. Wyświetl produkty");
                Console.WriteLine("2. Wyświetl zamówienia");
                Console.WriteLine("3. Szczegóły zamówienia");
                Console.WriteLine("4. Dodaj nowe zamówienie");
                Console.WriteLine("5. Generuj raport sprzedaży");
                Console.WriteLine("6. Wyjście");
                Console.Write("Wybierz opcję: ");
                var choice = Console.ReadLine();
                    
                switch (choice)
                {
                    case "1":
                        Console.Write("Lista kategorii: \n");
                        var category_list = categoryRepo.GetCategoryNames();
                        int i = 1;
                        Console.ForegroundColor = ConsoleColor.Blue;

                        foreach (var catName in category_list) {
                            Console.Write($"# {i}. {catName} \n");
                            i++;
                        }

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Filtrowanie po kategorii (enter - pomiń filtrowanie): ");
                        Console.ResetColor();
                        var category = Console.ReadLine();
                        if (category != "")
                        {
                            var products = productRepo.GetProductsByCategory(category);
                            foreach (var product in products)
                            {
                                Console.WriteLine($"ID: {product.ProductID}, Produkt: {product.Name}, Cena: {product.ListPrice:C}");
                            }
                        }
                        else {
                            var products = productRepo.GetProducts();
                            foreach (var product in products)
                            {
                                Console.WriteLine($"ID: {product.ProductID}, Produkt: {product.Name}, Cena: {product.ListPrice:C}");
                            }
                        }
                            break;
                    case "2":
                        orderService.ShowOrdersList();
                        break;
                    case "3":
                        Console.Write("Podaj ID zamówienia: ");
                        if (int.TryParse(Console.ReadLine(), out int orderId))
                        {
                            orderService.ShowOrderById(orderId);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Dodawanie zamówienia");
                        try
                        {
                            Console.Write("Podaj imię zamawiającego:");
                            String name = Console.ReadLine();

                            Console.Write("Podaj nazwisko zamawiającego:");
                            String lastName = Console.ReadLine();

                            //1) DODAWANIE KLIENTA
                            var customer = customerService.CreateCustomer(name, lastName);


                            //Wybór metody dostawy
                            Console.WriteLine("Wybierz metodę dostawy: ");
                            var shipMethod_list = shipMethodReop.GetShipMethods();
                            foreach (var method in shipMethod_list) {
                                Console.WriteLine($"ID: {method.ShipMethodID} | {method.Name}");
                            }
                            // parsowanie id dostawy
                            int.TryParse(Console.ReadLine(), out int shipMethodId);

                            //2) DODAWANIE PRODUKTÓW

                            //lista produktów która zostanie potem dodana do zamówienia
                            var product_list = productService.GetSalesOrderDetailsList();


                            //3) TWORZENIE ZAMÓWIENIA: 
                            orderService.CreateOrder(customer, shipMethodId, product_list);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Błąd: {ex.Message}");
                            if (ex.InnerException != null)
                                Console.WriteLine($"Szczegóły: {ex.InnerException.Message}");
                        }

                        break;
                    case "5":
                        var report = orderRepo.GetSalesReportByCategory();
                        foreach (var item in report)
                        {
                            Console.WriteLine($"Kategoria: {item.Category} - Sprzedaż: {item.TotalSales:C}");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Koniec programu.");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }
    }
}
