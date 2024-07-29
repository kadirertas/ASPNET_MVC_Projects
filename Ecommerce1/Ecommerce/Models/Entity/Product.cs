using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Models.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl{ get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string CompanyName { get; set; }
        public int CategoryId { get; set; }


        public DateTime CreatedDate { get; set; }
        
    }
}
