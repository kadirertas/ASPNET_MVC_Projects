using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Entity
{
    public class Category
    {


        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [Required]
        public string CategoryImageUrl { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
     
    }
}
