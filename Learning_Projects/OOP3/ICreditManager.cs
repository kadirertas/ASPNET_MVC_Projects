using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     interface ICreditManager  // Kredi Manager
        //  Interface kullanan bir  Class yapısı interface de bulunan metotları içermmek zorunndadır
        // Okunurluğu artıtmak amacıyla interface isimleri yukarda görüldüğü üzere I takısı alır 

        /*NOT: : :  
         Interfaceler birbirinin alternatifleri olan fakat kod içerikleri farklı olan durumlar için KULLANIRIZ*/

    {

         void Hesapla();

        void BiseyYap(); 

    }
}
