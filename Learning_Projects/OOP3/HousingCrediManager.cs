using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HousingCrediManager : ICreditManager // Konut Kredi Manager 

    // Interface kullanan bir Class yapısı interface içinde bulunan metotları içermek zorundadır 

    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı ");
        }
    }
}
