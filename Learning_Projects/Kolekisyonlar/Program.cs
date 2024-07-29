using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekisyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[] { "ahmet", "ismet", "mehmet", "selami ", "mustafa " };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine(isimler[4]);
            isimler = new string[5];
            isimler[4]="selam bebek mugo ben kelebek";
            Console.WriteLine(isimler[4]);

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[4]);
        }
    }
}
