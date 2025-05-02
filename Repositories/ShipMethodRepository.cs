using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Repositories
{
    class ShipMethodRepository
    {
        private readonly AdventureWorksContext _context;

        public ShipMethodRepository(AdventureWorksContext context)
        {
            _context = context;
        }

        public IEnumerable<ShipMethod> GetShipMethods()
        {
            Logger.LogOperation("Pobrano listę metod wysyłki.");
            return _context.ShipMethods.ToList();
        }
    }
}
