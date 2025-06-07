using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Models;
using AdventureWorks.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repositories
{
    public class ProductRepository
    {
        private readonly AdventureWorksContext _context;

        public ProductRepository(AdventureWorksContext context)
        {
            _context = context;
        }

        public Product? GetProductById(int productId)
        {
            var product = _context.Products
                .FirstOrDefault(p => p.ProductID == productId);
            Logger.LogOperation(product != null
                ? $"Pobrano produkt o ID {productId}."
                : $"Nie znaleziono produktu o ID {productId}.");

            if (product == null)
            {
                throw new DbUpdateException("Niepowodzenie, nie ma produktu o takim id ! ");

            }

            return product;
        }
        public IEnumerable<Product> GetProducts()
        {
            Logger.LogOperation("Pobrano listę wszystkich produktów.");
            return _context.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(string categoryName)
        {
            Logger.LogOperation($"Pobrano produkty z kategorii: {categoryName}.");
            return _context.Products
                .Include(p => p.ProductSubcategory)
                .ThenInclude(sc => sc.ProductCategory)
                .Where(p => p.ProductSubcategory != null && p.ProductSubcategory.ProductCategory.Name == categoryName)
                .ToList();
        }

    }

}
