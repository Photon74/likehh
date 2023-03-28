namespace BlazorFront.Data
{
    public class VacancyDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string? Position { get; set; }
        public decimal? Salary { get; set; }
        public string? Description { get; set; }
        public ProfileDto Profile { get; set; }
        public bool IsDraft { get; set; } = true;
    }
}
