using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public Customer(int ID, string city, string firstName, string lastname)
        {
            Id = ID;
            City = city;
            FirstName = firstName;
            LastName = lastname;
        }
        public Customer()
        {
            Console.WriteLine(" Default Yapıcı Blok Çalıştı"); 
        }
        public int Id{ get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
