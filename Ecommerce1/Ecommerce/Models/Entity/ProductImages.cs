namespace Ecommerce.Models.Entity
{
    public class ProductImage
    {
        public int ImagesId { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public bool? DefaultImage { get; set; }
    }
}
