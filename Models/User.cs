using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace DriveRentSales.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(45), Required]
        public string Username { get; set; }

        [EmailAddress, StringLength(100), Required]
        public string Email { get; set; }

        [PasswordPropertyText, StringLength(45), Required]
        public string PasswordHash { get; set; }

        [Required, Range(18, 100)]
        public int Age { get; set; }

        [ForeignKey(nameof(IdRole)), Required]
        public int IdRole { get; set; }

        [Required]
        public Blob DrivingLicense { get; set; }
    }
}
