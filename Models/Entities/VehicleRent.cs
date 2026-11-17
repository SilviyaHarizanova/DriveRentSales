using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveRentSales.Models.Entities
{
    public class VehicleRent:IEntity
    {
        [Key]
        public int Id { get; set; }

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


        public List<RentalBooking>? RentalBookingList { get; set; } = new List<RentalBooking>();


        public List<Review>? ReviewList { get; set; } = new List<Review>();
    }
}
