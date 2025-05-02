using AdventureWorks;
using AdventureWorks.Models;
using AdventureWorks.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services
{
    class OrderService
    {
        private readonly AdventureWorksContext _context;
        private OrderRepository orderRepo;
        public OrderService(AdventureWorksContext context){
            _context = context;
            orderRepo = new OrderRepository(_context);
        }
        public void ShowOrderById(int orderId) {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var order = orderRepo.GetOrderDetails(orderId);
                if (order != null)
                {
                    Console.WriteLine($"Zamówienie ID: {order.SalesOrderID}, Numer: {order.SalesOrderNumber}, Data: {order.OrderDate}, Wartość: {order?.SubTotal}, Podatek: {order?.TaxAmt}, Metoda Dostawy: {order?.ShipMethod?.Name},  Data dostawy: {order?.ShipDate}, ");
                    Console.WriteLine($"Klient: {order?.Customer?.Person?.FirstName} {order?.Customer?.Person?.LastName}");

                    Console.WriteLine("Lista produktów: ");
                    foreach (var detail in order.SalesOrderDetails)
                    {
                        Console.WriteLine($"* ID:{detail.ProductID} | Nazwa: {detail.Product?.Name} | Ilość: {detail.OrderQty} szt. x Cena: {detail.UnitPrice:C}");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nie znaleziono zamówienia.");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Wystąpił błąd przy wyświetlaniu zamówienia: {ex.Message}");
                Logger.LogOperation($"[BŁĄD] ShowOrderById({orderId}): {ex.Message}");
            }
            finally
            {
                Console.ResetColor();
            }
        }

        public void ShowOrdersList() {
            var order_list = orderRepo.GetOrders();
            foreach (var order in order_list)
            {
                Console.WriteLine($"ID: {order.SalesOrderID}, Numer: {order.SalesOrderNumber}, Data: {order.OrderDate} Wartość: {order.SubTotal}, Podatek: {order.TaxAmt}");
            }
        }
        public void CreateOrder(Customer customer, int shipMethodId, List<SalesOrderDetail> product_list) {
            Decimal subTotal = product_list.Sum(detail => detail.UnitPrice * detail.OrderQty); //obliczenie wartości zamówienia funkcją lambda
            Decimal Tax = subTotal * 0.23m;//obliczenie podatku

            var newOrder = new SalesOrderHeader
            {
                CustomerID = customer.CustomerID,
                OrderDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                ShipDate = DateTime.Now.AddDays(2),
                Status = 1,
                OnlineOrderFlag = true,
                //  SalesOrderNumber = "SO99999", // generowane automatycznie
                //  PurchaseOrderNumber = "PO123456", generowane automatycznie
                //  AccountNumber = "10-4020-000676", // generowane automatycznie
                ShipMethodID = shipMethodId, // wymagane!
                ShipToAddressID = 1,
                BillToAddressID = 1,
                SalesOrderDetails = product_list,
                SubTotal = subTotal,
                TaxAmt = Tax //wartość podatku VAT
            };

            orderRepo.AddOrder(newOrder);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dodano nowe zamówienie. ID zamówienia: {newOrder.SalesOrderID}");
            Console.ForegroundColor = ConsoleColor.Cyan;


            if (newOrder != null)
            {
                Console.WriteLine($"Numer: {newOrder.SalesOrderNumber}, Data: {newOrder.OrderDate}, Wartość: {newOrder.SubTotal}, Podatek: {newOrder.TaxAmt}, Metoda Dostawy: {newOrder.ShipMethod.Name},  Data dostawy: {newOrder.ShipDate}, ");
                Console.WriteLine($"Klient: {newOrder.Customer?.Person?.FirstName} {newOrder.Customer?.Person?.LastName}");

                Console.WriteLine("Lista produktów: ");
                foreach (var detail in newOrder.SalesOrderDetails)
                {
                    Console.WriteLine($"* ID:{detail.ProductID} | Nazwa: {detail.Product.Name} | Ilość: {detail.OrderQty} szt. x Cena: {detail.UnitPrice:C}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błąd w tworzeniu zamówienia.");
            }
            Console.ResetColor();

        }

    }
}
