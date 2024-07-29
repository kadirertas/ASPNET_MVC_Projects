using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class NeedCrediManager : ICreditManager   // İhtiyaç Kredi Manager
   // Interface kullanan bir Class yapısı interface içindeki metotoları içermek zorundadır
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı ");   
        }
    }
}
