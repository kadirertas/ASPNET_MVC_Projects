using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerictsIntro4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<string>  myList= new MyList<string>();

            myList.Add("1ewfds");   
            Console.WriteLine(myList.Count);
            myList.Add("2gdvdfvfd");    
            Console.WriteLine(myList.Count);
            myList.Add("3dfgdtddt");                
            Console.WriteLine(myList.Count);
            myList.Add("4gerthgrtht");                
            Console.WriteLine(myList.Count);
            myList.Add("5dhtthjytytdht");                
            Console.WriteLine(myList.Count);
            myList.Add("6");

             
                
                
                
        }
    }
}
