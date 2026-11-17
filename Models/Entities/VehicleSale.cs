using System.ComponentModel.DataAnnotations;

namespace DriveRentSales.Models.Entities
{
    public class VehicleSale:IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(45)]
        public string Model { get; set; }

        [Required, StringLength(45)]
        public string Brand { get; set; }

        [Required]
        public int Year { get; set; }

        [Required, StringLength(45)]
        public string Fuels { get; set; }

        [Required, StringLength(45)]
        public string Gearbox { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool Status { get; set; }

        public int IdUser { get; set; }
        public User? User { get; set; }
    }
}
