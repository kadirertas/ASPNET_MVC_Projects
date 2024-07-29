using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionary kısaca  key ve  Value değerler tutabilen koleksiyon yapısıdır bu yapıda Add , Remove , Count gibi birçok methot barındırır */
            Dictionary<string,int > Adyas= new Dictionary<string,int>();

            Adyas.Add("mehmet", 17);
            Adyas.Add("selami ", 46 );
            Adyas.Add("şukufe", 12);


            foreach (var item in Adyas)
            {
                Console.WriteLine(item); 

            }

            var eleman = Adyas.Count; 
            Console.WriteLine(eleman);

            Adyas.Remove("mehmet");

            foreach (var item in Adyas)
            {
                Console.WriteLine(item);

            }

        
        }
    }
}
