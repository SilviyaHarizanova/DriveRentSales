using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveRentSales.Models
{
    public class RentalBooking
    {
        [Key, ForeignKey(nameof(IdUser))]
        public int IdUser { get; set; }

        [Key, ForeignKey(nameof(IdVehicleRent))]
        public int IdVehicleRent { get; set; }

        [Required]
        public DateOnly PeriodStart { get; set; }

        [Required]
        public DateOnly PeriodEnd { get; set; }
    }
}
