namespace BlazorFront.Models
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Position { get; set; }
        public string? Description { get; set; }
        public Resume Resume { get; set; }
        public bool IsDraft { get; set; } = true;
    }
}
