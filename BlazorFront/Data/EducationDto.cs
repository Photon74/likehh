namespace BlazorFront.Data;

public class EducationDto
{
    public int Id { get; set; }
    public string InstitutionName { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Description { get; set; }
    public ResumeDto Resume { get; set; }
    public bool IsDraft { get; set; } = true;
}