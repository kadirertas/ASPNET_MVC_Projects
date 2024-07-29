// See https://aka.ms/new-console-template for more information
using ClassMetodsDemo;

Console.WriteLine("Hello, World!");



Customer customer1 = new Customer();
customer1.Id = 1;
customer1.CustomerName = "Sami";
customer1.CustomerEmail = "sami@gmail.com";
customer1.CustomerPhone = "555555555555555";
customer1.CustomerCity = "Ankara";
customer1.CustomerBalance = 444444440;

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.CustomerName = "Ayşe";
customer2.CustomerEmail = "ayse@gmail.com";
customer2.CustomerPhone = "555555555555556";
customer2.CustomerCity = "Istanbul";
customer2.CustomerBalance = 333333330;

Customer customer3 = new Customer();
customer3.Id = 3;
customer3.CustomerName = "Mehmet";
customer3.CustomerEmail = "mehmet@gmail.com";
customer3.CustomerPhone = "555555555555557";
customer3.CustomerCity = "Izmir";
customer3.CustomerBalance = 220;

Customer customer4 = new Customer();
customer4.Id = 4;
customer4.CustomerName = "Elif";
customer4.CustomerEmail = "elif@gmail.com";
customer4.CustomerPhone = "555555555555558";
customer4.CustomerCity = "Bursa";
customer4.CustomerBalance = 1111;

Customer customer5 = new Customer();
customer5.Id = 5;
customer5.CustomerName = "Ahmet";
customer5.CustomerEmail = "ahmet@gmail.com";
customer5.CustomerPhone = "555555555555559";
customer5.CustomerCity = "Antalya";
customer5.CustomerBalance = 555555550;

Customer customer6 = new Customer();
customer6.Id = 6;
customer6.CustomerName = "Fatma";
customer6.CustomerEmail = "fatma@gmail.com";
customer6.CustomerPhone = "555555555555560";
customer6.CustomerCity = "Adana";
customer6.CustomerBalance = 6660;

Customer[] customerss = new Customer[] { customer1, customer2, customer3 , customer4, customer5, customer6};

CustomerManager customerManager = new CustomerManager();


foreach (Customer customer in customerss) 
{

    customerManager.Add(customer);
}

Console.WriteLine("----------------\n\n");
customerManager.Write(); 