using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {

        public int Id { get; set; }   //urun ID numarası 
        public int CategoryID { get; set; }  //  urun categori ID nuamrası 
        public string  ProductName { get; set; }  // urun adi 
        public double UnitPrice { get; set; } // unrun fiyati 
        public int UnitsInStock  { get; set; } // urunun stok adedi 

        // CRUD => Create Read Update Delete

        
    }
}
