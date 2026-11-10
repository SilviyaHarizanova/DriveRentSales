using System.ComponentModel.DataAnnotations;

namespace DriveRentSales.Models.Entities
{
    public class Role:IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(45), Required]
        public string Name { get; set; }
    }
}
