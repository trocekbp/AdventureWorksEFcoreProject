using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repositories
{
    public class CustomerRepository
    {
        private readonly AdventureWorksContext _context;

        public CustomerRepository(AdventureWorksContext context)
        {
            _context = context;
        }

        public int? FindCustomerIdByName(string firstName, string lastName)
        {
            var customer = _context.Customers
                .Include(c => c.Person)
                .FirstOrDefault(c => c.Person.FirstName == firstName && c.Person.LastName == lastName);

            Logger.LogOperation(customer != null
                ? $"Znaleziono klienta: {firstName} {lastName}."
                : $"Nie znaleziono klienta: {firstName} {lastName}.");
            return customer?.CustomerID;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            Logger.LogOperation("Pobrano listę wszystkich klientów.");
            return _context.Customers
                .Include(c => c.Person)
                .ToList();
        }

        public Customer? GetCustomerById(int customerId)
        {
            var customer = _context.Customers
                .Include(c => c.Person)
                .FirstOrDefault(c => c.CustomerID == customerId);

            Logger.LogOperation(customer != null
                ? $"Pobrano klienta o ID {customerId}."
                : $"Nie znaleziono klienta o ID {customerId}.");
            return customer;
        }
    }
}
