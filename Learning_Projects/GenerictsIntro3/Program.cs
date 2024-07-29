using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerictsIntro3
{
    internal class Program
    {
        static void Main(string[] args)
        {   



            MyList<int> sayilar = new MyList<int>();

            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
                
            sayilar.Add(4);
                
            sayilar.Add(5);
                
            sayilar.Add(6);
                
                
            sayilar.Add(7);
                
            Console.WriteLine(sayilar.Length);




        }
    }
}
