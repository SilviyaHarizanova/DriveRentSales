using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveRentSales.Models.Entities
{
    public class MaintanceLog:IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdVehicleRent { get; set; }

        public VehicleRent? VehicleRent { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
