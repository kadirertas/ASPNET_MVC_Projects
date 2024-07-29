using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kadir Ertaş 

            GercekMusteri Musteri1= new GercekMusteri();
            
            Musteri1.Id = 1;
            Musteri1.CustomerNumber = "12345456";
            Musteri1.FirstName="Kadir";
            Musteri1.LastName = "Ertaş";
            Musteri1.TcNumber = "222222222";


            // Ertaş Holding 

           TuzelMusteri  Musteri2 = new TuzelMusteri();

            Musteri2.Id = 2;
            Musteri2.CustomerNumber = "5412541";
            Musteri2.CompanyName = "Ertas Holding ";
            Musteri2.TaxNumber = "98465132"; 


            Musteri Musteri3= new TuzelMusteri();
            Musteri Musteri4= new GercekMusteri();
            /*Satır 35-36 da görüldüğü gibi  ata class kendisi miras alan classın referans no sunu tutabilir
             Buna Poliformizm yani çok biçimlilik denir */
        }
    }
}
