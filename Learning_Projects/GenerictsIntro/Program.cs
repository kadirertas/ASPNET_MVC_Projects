using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerictsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MyList<string> myList= new MyList<string>();


            myList.Add("ahmet");
            Console.WriteLine(myList.Length);
            myList.Add("mehmet");
            Console.WriteLine(myList.Length);
            

        }
    }
}
