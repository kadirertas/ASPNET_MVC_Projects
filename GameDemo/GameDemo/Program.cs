



using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;

Customer customer = new Customer();

customer.FirstName = "Kadir";
customer.LastName = "Ertaş"; 
customer.Balance = 2000;
customer.Id = 1;
customer.NationalityId = "11201980800"; 
customer.DateOfBirth = new DateTime (2002, 12, 1);

ICustomerManager customerManager = new CustomerManager(new CheckPersonManager());


Console.WriteLine("\n\n\n--------------------------USER--------------------------------");
customerManager.Add(customer);
customerManager.Update(customer); 
customerManager.Remove(customer);




Game game = new Game();

game.Id = 1;
game.GameName = "Far CRY 3";
game.GameDescription = "Güzel bir aksiyon oyunu ";
game.GamePrice = 20;


GameManager gameManager = new GameManager();

Console.WriteLine("\n\n\n--------------------------GAME--------------------------------");
gameManager.Add(game);
gameManager.Update(game); 
gameManager.Remove(game);   




Campagin campagin = new Campagin(); 
campagin.Id = 1;
campagin.CampaginName = "Yaz sezonu kampanyası ";
campagin.CampaginDescription = "Yaz sezonuna özel 28 agustosa kadar her oyunda %20 indirim "; 
campagin.CampaginPercentPrice = 20;

CampaginManager campaginManager = new CampaginManager();

Console.WriteLine("\n\n\n--------------------------CAMPAGİN--------------------------------");
campaginManager.Add(campagin);
campaginManager.Update(campagin);
campaginManager.Remove(campagin);   
