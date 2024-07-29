using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Entity
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
