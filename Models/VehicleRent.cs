using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveRentSales.Models
{
    public class VehicleRent
    {
        [Key]
        public int IdVehicleRent { get; set; }

        [Required, StringLength(45)]
        public string RegistrationNumber { get; set; }

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
        public decimal DayRentPrice { get; set; }

        [Required, StringLength(45)]
        public string Status { get; set; }

        [ForeignKey(nameof(IdRentalBooking)), Required]
        public int IdRentalBooking { get; set; }

        [ForeignKey(nameof(IdReview)), Required]
        public int IdReview { get; set; }
    }
}
