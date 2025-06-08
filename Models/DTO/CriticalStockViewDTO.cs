using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Models.DTO
{
    //Klasa Data Transfer Object potrzebna do pobrania wyników z zapytania generującego raport
    //o produktach ze zbyt niskim stanem
    public class CriticalStockViewDTO
    {
        public int ProductID { get; set; }
        public String Name { get; set; }
        public short ReorderPoint { get; set; }
        public int TotalQuantity { get; set; }
    }
}
