namespace Ecommerce.Models.Entity
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedData { get; set; }
    }
}
