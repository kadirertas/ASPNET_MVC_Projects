using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerictsIntro2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isim = new MyList<string>();


            isim.Add("selami");
            Console.WriteLine(isim.Length);

            isim.Add("selami");
            Console.WriteLine(isim.Length);
                
                
                isim.Add("selami");
            Console.WriteLine(isim.Length);
            
               isim.Add("selami");
            Console.WriteLine(isim.Length);

            Console.ReadLine(); 

        }
    }
}
