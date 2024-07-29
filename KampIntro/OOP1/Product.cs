using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {

        public int Id    { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; internal set; }
        public     bool UnitsInStock { get; set; }

        public double UnitPrice { get; set; }


      
    }
}
