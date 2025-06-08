using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repositories
{
    public class OrderRepository
    {
        private readonly AdventureWorksContext _context;

        public OrderRepository(AdventureWorksContext context)
        {
            _context = context;
        }

        public IEnumerable<SalesOrderHeader> GetOrders()
        {
            Logger.LogOperation("Pobrano listę zamówień.");
            return _context.SalesOrderHeaders.ToList();
        }

        public SalesOrderHeader GetOrderDetails(int orderId)
        {
            var order = _context.SalesOrderHeaders
                .Include(o => o.Customer)
                    .ThenInclude(c => c.Person)
                .Include(o => o.SalesOrderDetails)
                    .ThenInclude(d => d.Product)
                 .Include(o => o.ShipMethod)
                .FirstOrDefault(o => o.SalesOrderID == orderId);

            Logger.LogOperation($"Pobrano szczegóły zamówienia o ID {orderId}.");
            return order;
        }

        public void AddOrder(SalesOrderHeader order)
        {
            _context.SalesOrderHeaders.Add(order);
            _context.SaveChanges();
            Logger.LogOperation($"Dodano nowe zamówienie o ID {order.SalesOrderID} dla klienta ID {order.CustomerID}.");
        }

        public IEnumerable<dynamic> GetSalesReportByCategory()
        {
            var report = _context.SalesOrderDetails
                .Include(d => d.Product)
                    .ThenInclude(p => p.ProductSubcategory)
                    .ThenInclude(sc => sc.ProductCategory)
                 .Where(d =>
                    d.Product.ProductSubcategory != null &&
                    d.Product.ProductSubcategory.ProductCategory != null &&
                    !string.IsNullOrEmpty(d.Product.ProductSubcategory.ProductCategory.Name)
                )
                .GroupBy(d => d.Product.ProductSubcategory.ProductCategory.Name)
                .Select(g => new
                {
                    Category = g.Key,
                    TotalSales = g.Sum(x => x.LineTotal)
                })
                .ToList();

            Logger.LogOperation("Wygenerowano raport sprzedaży według kategorii.");
            return report;
        }

        public SalesOrderHeader GetOrderHeader(int ID) {

            var order = _context.SalesOrderHeaders
                                .Include(od => od.SalesOrderDetails)
                                .FirstOrDefault(o => o.SalesOrderID == ID);
          
            return order;
        }
        public void DeleteOrder(SalesOrderHeader order) {

            _context.SalesOrderHeaders.Remove(order);

            try
            {
                _context.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {

                Console.WriteLine("Błąd zapisu do bazy: " + ex.Message);

                // Jeśli istnieje warstwa wewnętrznego wyjątku, wypisz jego treść:
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Szczegóły wewnętrznego wyjątku: " +
                                      ex.InnerException.Message);
                }
            }

        }
    }
}