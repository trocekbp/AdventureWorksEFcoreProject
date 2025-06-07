using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repositories
{
    public class CategoryRepository
    {
        private readonly AdventureWorksContext _context;

        public CategoryRepository(AdventureWorksContext context)
        {
            _context = context;
        }

        
        public IEnumerable<ProductCategory> GetCategoriesAndSubCategories()
        {
            Logger.LogOperation("Pobrano listę subkategorii i  kategorii.");
            return _context.ProductCategories
                    .Include(sc => sc.ProductSubcategories);
        }

        public IEnumerable<string> GetCategoryNames()
        {
            Logger.LogOperation("Pobrano listę nazw kategorii.");
            return _context.ProductCategories
                .Select(c => c.Name)
                .OrderBy(name => name)
                .ToList();
        }
    }
}
