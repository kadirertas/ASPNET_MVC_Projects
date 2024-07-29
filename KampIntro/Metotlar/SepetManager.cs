using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        double toplam = 0;

        public void Ekle (Product product) 
        {

            Console.WriteLine(product.Adi + " Ürünü Sepete Eklendi ");

            toplam += product.Fiyati; 
            Console.WriteLine("Anlık Sepetin toplam Fiyati: " + toplam +"\n\n\n");
         
        }
    }
}
