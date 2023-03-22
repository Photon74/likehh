namespace BlazorFront.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }
        public string? Photo { get; set; }
        public Role Role { get; set; } = Role.Employee;
        public User User { get; set; }
        public bool IsDraft { get; set; } = true;
    }
}
