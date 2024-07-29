using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class İslemler
    {

        




        public void toplama(double sayi1, double sayi2)
        {
            double sonuc = 0;
            sonuc = sayi1 + sayi2;

            Console.WriteLine("verilen sayıların toplamı"+ sonuc);
        }

        public void cikarma(double sayi1, double sayi2)
        {


            double sonuc = 0;
            if (sayi1 >= sayi2)
            {
                sonuc = sayi1 - sayi2;
            }
            else
            { sonuc = sayi2 - sayi1; }

            Console.WriteLine("verilen sayıların çıkarımı " + sonuc);

        }

        public void  carpma (double sayi1, double sayi2)   
        {

            double sonuc = 0;
            sonuc= sayi1 * sayi2;

            Console.WriteLine("verilen sayıların çarpımı " + sonuc );
        }

        public void bolme (double sayi1, double sayi2)
        {


            double sonuc = 0;
            if (sayi1 >= sayi2)
            {
                sonuc = sayi1 / sayi2;
            }
            else
            { sonuc = sayi2 / sayi1; }

            Console.WriteLine("verilen sayıların bölümü " + sonuc);

        }

    }
}
