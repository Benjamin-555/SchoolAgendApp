namespace SchoolAgendCRUD.DTOs
{
    public class SessionDto
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int DayOfWeek { get; set; } // 1 = Monday ... 7 = Sunday
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string? Classroom { get; set; }
    }
}
