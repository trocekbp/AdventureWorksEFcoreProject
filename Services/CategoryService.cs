using AdventureWorks.Models;
using AdventureWorks.Models.DTO;
using AdventureWorks.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services
{
    class CategoryService
    {
        private readonly AdventureWorksContext _context;
        private CategoryRepository categoryRepo;

        public CategoryService(AdventureWorksContext context)
        {
            _context = context;
            categoryRepo = new CategoryRepository(_context);
        }

        public int[] GetCategoriesIds() //Służy do wprowadzenia id kategorii i podkategorii
        {

  
            int catID = 1, subCatID = 1;

            var categories = categoryRepo.GetCategoriesAndSubCategories(); //kategorie z podkategoriami

            Console.WriteLine("--Lista kategorii--");
            foreach (var item in categories)
            {
                Console.WriteLine($"# {item.ProductCategoryID} | {item.Name}");
            }
            Console.Write("Wprowadź id kategorii: ");
            try
            {
                catID = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Błąd konwersji, ustawiam 1.");
                catID = 1;
            }
            if (catID != null)
            {
                var selectedCat = categories.FirstOrDefault(c => c.ProductCategoryID == catID);
                Console.WriteLine("--Lista podkategorii--");

                foreach (var item in selectedCat.ProductSubcategories) {
                    Console.WriteLine($"# {item.ProductSubcategoryID} | {item.Name}");
                }

                Console.Write("Wprowadź id podkategorii: ");
                try
                {
                    subCatID = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Błąd konwersji, ustawiam 1.");
                    subCatID = 1;
                }
            }
            else
                throw new Exception("Błąd wprowadzania kategorii");


            // [0] to id kategorii, [1] to id podkategorii
            return new int[2] { catID, subCatID }; ;
            
        } 

    }
}
