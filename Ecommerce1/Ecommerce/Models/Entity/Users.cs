using System;

namespace Ecommerce.Models.Entity
{
    public class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PostCode { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public int RolId { get; set; }
        public DateTime CreatedData { get; set; }
    }

}
