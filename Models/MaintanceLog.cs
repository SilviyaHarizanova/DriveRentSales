using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveRentSales.Models
{
    public class MaintanceLog
    {
        [Key]
        public int IdMaintanceLog { get; set; }

        [ForeignKey(nameof(IdMaintanceLog)), Required]
        public int IdVehicleRent { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
