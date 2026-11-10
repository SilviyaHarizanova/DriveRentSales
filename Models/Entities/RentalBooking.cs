using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveRentSales.Models.Entities
{
    public class RentalBooking
    {
        [Key]
        public int IdUser { get; set; }

        public User? User { get; set; }

        [Key]
        public int IdVehicleRent { get; set; }
        public VehicleRent? VehicleRent { get; set; }

        [Required]
        public DateOnly PeriodStart { get; set; }

        [Required]
        public DateOnly PeriodEnd { get; set; }
    }
}
