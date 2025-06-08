using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
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
            var categoryService = new CategoryService(context);
            var inventoryService = new ProductInventoryService(context);

            while (true)
            {
                Console.WriteLine("\n=== AdventureWorks Menu ===");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Zarządzanie produktami");
                Console.ResetColor();
                Console.WriteLine("1. Wyświetl produkty");
                Console.WriteLine("2. Szczegóły produktu");
                Console.WriteLine("3. Rejestracja nowego produktu");


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Zarządzanie stanami magazynowymi");
                Console.ResetColor();
                Console.WriteLine("4. Wyświetl stan magazynowy produktu");
                Console.WriteLine("5. Zmień stan magazynowy produktu");
                Console.WriteLine("6. Pokaż raport brakujących produktów w magazynach");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Zarządzanie zamówieniami");
                Console.ResetColor();
                Console.WriteLine("7. Wyświetl zamówienia");
                Console.WriteLine("8. Szczegóły zamówienia");
                Console.WriteLine("9. Dodaj nowe zamówienie");
                Console.WriteLine("10. Cofnij zamówienie");


                Console.WriteLine("11. Generuj raport sprzedaży");
                Console.WriteLine("12. Wyjście");
                Console.Write("Wybierz opcję: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Lista kategorii: \n");
                        var category_list = categoryRepo.GetCategoryNames();
                        int i = 1;
                        Console.ForegroundColor = ConsoleColor.Blue;

                        foreach (var catName in category_list)
                        {
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
                        else
                        {
                            var products = productRepo.GetProducts();
                            foreach (var product in products)
                            {
                                Console.WriteLine($"ID: {product.ProductID}, Produkt: {product.Name}, Cena: {product.ListPrice:C}");
                            }
                        }
                        break;
                    case "2":
                        // Szczegóły produktu
                        Console.Write("Podaj ID produktu: ");
                        if (int.TryParse(Console.ReadLine(), out int productId))
                        {
                            productService.ShowProductById(productId);
                        }
                        break;
                        break;
                    case "3":
                        // Rejestracja nowego produktu

                        Console.WriteLine("--Rejestracja nowego produktu--");
                        Console.Write("Podaj nazwę: ");
                        var prodName = Console.ReadLine();
                        Console.Write("Podaj numer produktu (pomiń w celu wygenerowania automatycznie): ");
                        var number = Console.ReadLine();

                        short safetyStock;
                        Console.Write("Podaj minimalną ilość: ");
                        var input = Console.ReadLine();
                        if (!short.TryParse(input, out safetyStock) || safetyStock <= 0)
                        {
                            Console.WriteLine("Błąd konwersji, ustawiam 1.");
                            safetyStock = 1;
                        }

                        Console.Write("Podaj bezpieczną ilość: "); //podajemy  ilość dla której trzeba zrobić nowe zaówienie, nie jest to safetyStockLevel
                        short reorderPoint;
                        input = Console.ReadLine();
                        if (!short.TryParse(input, out reorderPoint) || reorderPoint < safetyStock)
                        {
                            Console.WriteLine("Błąd konwersji, ustawiam 2.");
                            reorderPoint = 2;
                        }

                        Console.Write("Podaj cenę (z przecinkiem)");
                        decimal price;
                        try
                        {
                            price = Convert.ToDecimal(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Błąd konwersji, ustawiam 0.");
                            price = 0.0m;
                        }


                        int[] catIds = categoryService.GetCategoriesIds();
                        //[0] = categoryID [1] = subCategory id
                        var dto = new ProductDTO
                        {
                            Name = prodName,
                            ProductNumber = number,
                            MakeFlag = true,
                            FinishedGoodsFlag = true,
                            SafetyStockLevel = safetyStock,
                            ReorderPoint = reorderPoint,
                            StandardCost = price,
                            ListPrice = price,
                            ProductSubcategoryID = catIds[0],   // zakładamy, że taka podkategoria istnieje
                            ProductCategoryID = catIds[1]
                        };

                        //Zapisanie w bazie nowego produktu
                        try
                        {
                            var newProductId = await productService.RegisterProduct(dto);

                            if (newProductId != -1)
                            {
                                Console.WriteLine($"Pomyślnie zarejestrowano nowy produkt. ID: {newProductId}");

                                //wyświetlenie
                                productService.ShowProductById(newProductId);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Błąd: {ex.Message}");
                        }



                        break;
                    case "4":
                        //Wyświetl stan magazynowy produktu
                        //Zarządzanie stanami magazynowymi
                        Console.Write("Podaj ID produktu: ");
                        if (int.TryParse(Console.ReadLine(), out int productIdStk))
                        {
                            try
                            {
                                Console.WriteLine("\n ==Ilość produkty w magazynach== ");
                                inventoryService.ShowProductQuantity(productIdStk);

                            }
                            catch (DbUpdateException ex)
                            {
                                Console.WriteLine($"Błąd: {ex.Message}");
                                if (ex.InnerException != null)
                                    Console.WriteLine($"Szczegóły: {ex.InnerException.Message}");
                            }
                        }
                        break;
                    case "5":
                        //Zarządzanie stanami magazynowymi
                        Console.Write("Podaj ID produktu: ");
                        if (int.TryParse(Console.ReadLine(), out int productIdQty))
                        {
                            try
                            {
                                inventoryService.EditQuantity(productIdQty);
                                Console.WriteLine("\n ==Nowa ilość produkty na stanie== ");
                                inventoryService.ShowProductQuantity(productIdQty);

                            }catch (DbUpdateException ex)
                            {
                                Console.WriteLine($"Błąd: {ex.Message}");
                                if (ex.InnerException != null)
                                    Console.WriteLine($"Szczegóły: {ex.InnerException.Message}");
                            }
                        }
                        break;
                    case "6":
                        //Zarządzanie ze stanami poniżej minimalnego progu
                        try
                        {
                            await inventoryService.CriticalStockReportAsync();
                        }
                        catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                        {

                            Console.WriteLine("Błąd : " + ex.Message);

                            // Jeśli istnieje warstwa wewnętrznego wyjątku, wypisz jego treść:
                            if (ex.InnerException != null)
                            {
                                Console.WriteLine("Szczegóły wewnętrznego wyjątku: " +
                                                  ex.InnerException.Message);
                            }
                        }
                        break;
                    case "7":
                        orderService.ShowOrdersList();
                        break;
                    case "8":
                        Console.Write("Podaj ID zamówienia: ");
                        if (int.TryParse(Console.ReadLine(), out int orderId))
                        {
                            orderService.ShowOrderById(orderId);
                        }
                        break;
                    case "9":
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
                            foreach (var method in shipMethod_list)
                            {
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
                    case "10":
                        Console.Write("Podaj ID zamówienia do cofnięcia: ");

                        if (int.TryParse(Console.ReadLine(), out int orderToDelID))
                        {
                            orderService.ShowOrderById(orderToDelID);
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Czy na pewno chcesz cofnąć zamówienie ? T/N: ");
                        Console.ResetColor();
                        var response = Console.ReadLine();

                        if (response?.Equals("T", StringComparison.OrdinalIgnoreCase) == true)//bez znaczenia wielkości litery                                                                    
                        {
                            orderService.DeleteOrder(orderToDelID);
                        }
                        else if (response?.Equals("N", StringComparison.OrdinalIgnoreCase) == true)
                        {
                            //nie usuwanie zamówienia
                            break;
                        }
                        else {
                            Console.Write("Nieprawidłowa opcja");
                        }
                            break;
                        break;
                    case "11":
                        var report = orderRepo.GetSalesReportByCategory();
                        foreach (var item in report)
                        {
                            Console.WriteLine($"Kategoria: {item.Category} - Sprzedaż: {item.TotalSales:C}");
                        }
                        break;
                    case "12":
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
