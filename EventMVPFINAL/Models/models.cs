using System.ComponentModel.DataAnnotations;

namespace EventMVP.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Category { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        [Required]
        [StringLength(300)]
        public string Location { get; set; } = string.Empty;

        [Range(0, 10000)]
        public decimal Price { get; set; }

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Range(1, 10000)]
        public int MaxCapacity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}