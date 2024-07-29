using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RecourseManager  // Başvuru Manager

    {
        /*BaşvuruYap() ve KrediOnbilgilendirmesiYap () Metotlarının Tek Farkı biri veriyi tek tek alır diğeri Liste Halinde alır
         Yapacağı işi Foreach ile dolaşarak yapar
         */
        public void BaşuvruYap( ICreditManager creditManager , ILoggerService loggerService)
        {

            /* Interface Parametre olarak alındığında gelen her Classda Interface in HESAPLA metodu bulunduğundan 
             gelen her Class kendi Hesapla metodunu Çalışıtırır 
             */  
            creditManager.Hesapla();
            loggerService.Log(); 
        }

        public void KrediOnbilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var Credi in credits)
            {
               Credi.Hesapla();
            }
        }
    }
}
