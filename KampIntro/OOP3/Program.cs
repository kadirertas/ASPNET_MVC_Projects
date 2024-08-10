


// Interface birbrinin alternatifi olan fakat içeriği farklı olan işlemler için kullanılır              
using OOP3;

IKrediManager ihtiyacKrediManager =  new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();



KonutKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();


IKrediManager tasitKrediManager  =new TasitKrediManager();
//tasitKrediManager.Hesapla();

EsnafKrediManager esnafKrediManager = new EsnafKrediManager();

Console.WriteLine("\n\n Başvuru Yap Kısmı \n\n");
BasvuruManager basvuruManager =new BasvuruManager();
 

ILoggerService databaseLoggerService = new DatabaseLoggerService(); 
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, smsLoggerService };
List<ILoggerService> loggerServices1 = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, };
List<ILoggerService> loggerServices2 = new List<ILoggerService>() { databaseLoggerService, };


basvuruManager.BasvuruYap(tasitKrediManager, loggerServices);
Console.WriteLine("\n\n -------------------- \n\n");

basvuruManager.BasvuruYap(konutKrediManager, loggerServices1);
Console.WriteLine("\n\n -------------------- \n\n");

basvuruManager.BasvuruYap(esnafKrediManager, loggerServices2);


Console.WriteLine("\n\n ------------------- \n\n");

List<IKrediManager> krediler = new List<IKrediManager>() 
{ tasitKrediManager, konutKrediManager,ihtiyacKrediManager};

basvuruManager.KrediOnBilgilendirmesiYap(krediler); 