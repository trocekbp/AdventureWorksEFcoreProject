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
    public class CustomerService
    {
        private readonly AdventureWorksContext _context;
        private CustomerRepository customerRepo;

        public CustomerService(AdventureWorksContext context)
        {
            _context = context;
            customerRepo = new CustomerRepository(_context);
        }

        public Customer CreateCustomer(string firstName, string lastName)
        {
            // 0) Sprawdzenie, czy klient już istnieje
            if (customerRepo.FindCustomerIdByName(firstName, lastName) is int existingId)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Taki klient jest w bazie danych");
                Console.ResetColor();
                return customerRepo.GetCustomerById(existingId)!;
            }
            else
            {

                // 1) Dodajemy rekord do BusinessEntity
                var be = new BusinessEntity
                {
                    ModifiedDate = DateTime.Now,
                    rowguid = Guid.NewGuid()
                };
                _context.BusinessEntities.Add(be);
                _context.SaveChanges();  // teraz be.BusinessEntityID jest znane
                Logger.LogOperation($"Dodano Business Entity: {be.ToString}");

                // 2) Dodajemy do Person z poprawnym BusinessEntityID
                var person = new Person
                {
                    BusinessEntityID = be.BusinessEntityID,
                    FirstName = firstName,
                    LastName = lastName,
                    ModifiedDate = DateTime.Now,
                    NameStyle = false,
                    EmailPromotion = 0,
                    PersonType = "IN" //IN – Individual (klient detaliczny)
                };
                _context.People.Add(person);
                _context.SaveChanges();
                Logger.LogOperation($"Dodano osobę: {person.ToString}");



                // 3) Dodajemy Customer wskazującego na to samo BusinessEntityID
                var customer = new Customer
                {
                    PersonID = person.BusinessEntityID,
                    AccountNumber = "AW" + person.BusinessEntityID.ToString().PadLeft(6, '0'),
                    ModifiedDate = DateTime.Now,
                    rowguid = Guid.NewGuid()
                };
                _context.Customers.Add(customer);
                _context.SaveChanges();
                Logger.LogOperation($"Dodano klienta: {customer.ToString}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dodano nowego klienta");
                Console.ResetColor();
                return customer;
            }
        }


    }
}
