



using Constructors;

Customer cutomer = new Customer() { Id =1 , City ="İstanbul",  FirstName = "ERTAŞ", LastName = "HOLDİNG"};

Customer customer1 = new Customer(2, "Muş", "Kadir", "ertaş");




Console.WriteLine(cutomer.FirstName+" " +cutomer.LastName);
Console.WriteLine(customer1.FirstName + " " + customer1.LastName);
