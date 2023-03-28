namespace BlazorFront.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }
        public string Phone { get; set; }
        public DateOnly Birthday { get; set; }
        public string? Photo { get; set; }
        public Role Role { get; set; } = Role.None;
        public User User { get; set; }
    }
}
