using System.ComponentModel.DataAnnotations;

namespace EventMVP.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string UserEmail { get; set; } = string.Empty;

        [Range(1, 10)]
        public int TicketCount { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.UtcNow;

        public BookingStatus Status { get; set; } = BookingStatus.Confirmed;

        // Navigation property
        public virtual Event Event { get; set; } = null!;
    }

    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }
}

