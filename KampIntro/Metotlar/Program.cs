// See https://aka.ms/new-console-template for more information
using Metotlar;

Product product = new Product();
Product product1 = new Product();
Product product2 = new Product();
Product product3 = new Product();
product.Id = 1;
product.Adi= "Elma";
product.Aciklama = "Amasya Elması";
product.Fiyati = 20;


product1.Id = 2;
product1.Adi = "Muz";
product1.Aciklama = "Antalya Muzu";
product1.Fiyati = 40;

product2.Id = 2;
product2.Adi = "Kiraz ";
product2.Aciklama = "Tokat Kirazı";
product2.Fiyati = 70;

product3.Id = 2;
product3.Adi = "İncir ";
product3.Aciklama = "Aydın  İnciri";
product3.Fiyati = 160;

Product[] urunler = new Product[] {product, product1, product2, product3}; 


foreach (Product p in urunler) 
 {
    Console.WriteLine("Urun Id: "+ p.Id);
    Console.WriteLine("Urun Adi: "+ p.Adi);
    Console.WriteLine("Urun Fiyati: "+p.Fiyati);
    Console.WriteLine("Urun Aciklamasi: "+ p.Aciklama);
    Console.WriteLine("---------------------\n\n"); 
 }
Console.WriteLine("------------------------ Metods!-----------------------");

SepetManager    sepetManager = new SepetManager();
foreach (Product p in urunler) 
{

    sepetManager.Ekle(p); 
}



    Console.WriteLine("\n\n\n\n\n\n");
Console.WriteLine("------------------------Hello, World!-----------------------");

