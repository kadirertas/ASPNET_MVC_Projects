using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {


        public void Add (Product product )

        {
            //product.ProductName = " Kamera "; 
            Console.WriteLine(product.ProductName + " urunu  sepete eklendi "); 
        }


        public void Update (Product product ) 
        {
            Console.WriteLine(product.ProductName + "urunu güncellendi "); 
         }

      
    }
}
