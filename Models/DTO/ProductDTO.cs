using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Models.DTO
{

    /// Prosty obiekt przenoszący dane o produkcie do rejestracji.
    class ProductDTO
    {
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool MakeFlag { get; set; } = true;
        public bool FinishedGoodsFlag { get; set; } = true;
        public short SafetyStockLevel { get; set; } = 1; //minimalny stan
        public short ReorderPoint { get; set; } = 5; //minimalny stan przy którym trzeba już zamawiać

        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public int? ProductSubcategoryID { get; set; }   // opcjonalnie, jeśli chcemy powiązać podkategorię
        public int? ProductCategoryID { get; set; } // opcjonalnie, jeśli chcemy powiązać kategorię
    }
}
