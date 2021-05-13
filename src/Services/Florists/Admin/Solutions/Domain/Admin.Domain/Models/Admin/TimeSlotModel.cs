namespace Admin.Domain.Models.Admin
{
    public class TimeSlotModel
    {
        public string TimingsId { get; set; }
        public string StartTime { get; set; } //= (TimeSpan)reader["StartTime"];
        public string EndTime { get; set; } //(TimeSpan)reader["EndTime"];
        public string Timings { get; set; }
    }
}