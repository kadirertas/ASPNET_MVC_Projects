using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {            /*
             Şekilde görüldüğü üzere  18 24 30 inci satırlarda Poliformizim örenkleri vardır.
            ata Class çoçuğunun referans numarasını tuatibilir
             */
            //NeedCrediManager needCrediManager= new NeedCrediManager();
            //needCrediManager.Hesapla();
            ICreditManager needCrediManager2 = new NeedCrediManager(); 
            needCrediManager2.Hesapla();
             

            //VehicleCrediManager vehicleCrediManager= new VehicleCrediManager(); 
            //vehicleCrediManager.Hesapla();
            ICreditManager vehicleCrediManager2 = new VehicleCrediManager();
            vehicleCrediManager2.Hesapla();


            //HousingCrediManager housingCrediManager= new HousingCrediManager();
            //housingCrediManager.Hesapla(); 
            ICreditManager housingCrediManager2= new HousingCrediManager();
             housingCrediManager2.Hesapla();
            Console.WriteLine("\n\n-----------      ----------- \n\n");
            RecourseManager recourseManager = new RecourseManager();


            ILoggerService DatabaseLoggerService = new DatabaseLoggerService();
            ILoggerService FileLoggerService = new FileLoggerService();
            recourseManager.BaşuvruYap(needCrediManager2,DatabaseLoggerService);
            recourseManager.BaşuvruYap(housingCrediManager2,FileLoggerService);
            recourseManager.BaşuvruYap(vehicleCrediManager2,DatabaseLoggerService);
            Console.WriteLine("\n\n-----------      ----------- \n\n");


            List<ICreditManager> Credits = new List<ICreditManager>() {needCrediManager2 ,housingCrediManager2,vehicleCrediManager2};
    
            recourseManager.KrediOnbilgilendirmesiYap(Credits);
            ICreditManager EsnafCrediManager= new EsnafCrediManager();
            ILoggerService SMSLoggerService= new SMSLoggerService();
            RecourseManager recourseManager2 = new RecourseManager();       
            Console.WriteLine("\n\n-----------      ----------- \n\n");
            recourseManager2.BaşuvruYap(EsnafCrediManager, SMSLoggerService);














        }
    }
}
