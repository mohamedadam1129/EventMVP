namespace EventMVP.Models
{
    public class DashboardStats
    {
        public int TotalEvents { get; set; }
        public int TotalBookings { get; set; }
        public decimal TotalRevenue { get; set; }
        public int UpcomingEvents { get; set; }
        public List<CategoryStats> CategoryBreakdown { get; set; } = new List<CategoryStats>();
        public List<MonthlyRevenue> MonthlyRevenue { get; set; } = new List<MonthlyRevenue>();
    }

    public class CategoryStats
    {
        public string Category { get; set; } = string.Empty;
        public int EventCount { get; set; }
        public decimal Revenue { get; set; }
    }

    public class MonthlyRevenue
    {
        public string Month { get; set; } = string.Empty;
        public decimal Revenue { get; set; }
    }
}
