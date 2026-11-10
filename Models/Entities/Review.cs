using System.ComponentModel.DataAnnotations;

namespace DriveRentSales.Models.Entities
{
    public class Review:IEntity 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUser { get; set; }
        public User? User { get; set; }
        [Required]
        public double Rate { get; set; }
        public string TextReview { get; set; }
        [Required]
        public int IdVehicleRent { get; set; }
        public VehicleRent? VehicleRent { get; set; }
    }
}
