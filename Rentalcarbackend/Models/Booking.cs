using System.ComponentModel.DataAnnotations;

namespace Rentalcarbackend.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CarId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User? User { get; set; }
        public Car? Car { get; set; }
    }
}   