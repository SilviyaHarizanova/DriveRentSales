using System.ComponentModel.DataAnnotations;

namespace DriveRentSales.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        [StringLength(45), Required]
        public string Name { get; set; }
    }
}
