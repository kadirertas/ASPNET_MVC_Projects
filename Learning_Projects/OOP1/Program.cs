using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product(); 

            product1.Id= 1;
            product1.CategoryID= 2;                                           //nesne tnaımlama 2 türde gerçekleşir
            product1.ProductName = "masa";                                    // ya normal bilinen şekilide nesneyi oluşturur özelliklerini
                                                                              // değişiken gibi verir

                                                                              // ya da  27. satırda da olduğu gibi newledğin kısma süslü parantez atar
                                                                              // özellikleri içine yazarız
            product1.UnitPrice = 500; 
            product1.UnitsInStock= 10;

            Product product2 = new Product { Id=5, CategoryID=25, ProductName="sandalye",UnitPrice=150, UnitsInStock=68};

            Product product3 = new Product { Id = 8, CategoryID = 25, ProductName = "dolap ", UnitPrice = 150, UnitsInStock = 68 };

            Product product4 = new Product { Id = 63, CategoryID = 25, ProductName = "buzdolabı ", UnitPrice = 150, UnitsInStock = 68 };

            Product[] products= new Product[] { product1, product2,product3,product4 };

            ProductManager productManager= new ProductManager();


            
            foreach (var item in products )
            {

               


                Console.WriteLine(item.Id);
                Console.WriteLine(item.CategoryID);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.UnitPrice);
                Console.WriteLine(item.UnitsInStock);
                Console.WriteLine("------------------------------");
                Console.WriteLine("\n \n ");              
            }


            // deger tipler int string bool float dır ver değer tiplerde atamalar  sadece değerle yapılır  , 
            // referans tipler class diziler abstract classlar interface lerdir ve rerefans tip atamaları adres ile yapılır
            
            
           

        }
    }
}
