using System.ComponentModel.DataAnnotations;

namespace DriveRentSales.Models
{
    public class VehicleSale
    {
        [Key]
        public int IdVehicleSale { get; set; }

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
    }
}
