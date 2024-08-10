using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductService
    {


        public void Add (Product product) 
        {

            Console.WriteLine( product.ProductName+ " Ürünü " + product.UnitsInStock + " adet olarak sisteme Eklendi "); 


        
        }


        public void Update (Product product)
        {

            Console.WriteLine(product.ProductName + " Ürünü Güncellendi ");  
        }
    }
}
