using BlazorFront.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorFront
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Vacancy> Vacancy { get; set; }
        public DbSet<WorkExperience> WorkExperience { get; set; }
        public DbSet<Education> Education { get; set; }

        public ApplicationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=likehh.db");
        }
    }
}
