namespace CoffeApp.Models.Entity
{
    public class Products
    {


        public int ProductId { get; set; }
        public int CategoryId { get; set; }


        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string ProductImageUrl { get; set; }
        public string Description { get; set; }=string.Empty;

    }
}
