using Microsoft.EntityFrameworkCore;
using UniversityJobCommunicationServiceDotNet.Data.Model;

namespace UniversityJobCommunicationServiceDotNet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>(entity => { entity.HasIndex(e => e.Name).IsUnique(); });
            modelBuilder.Entity<Resume>(entity => { entity.HasIndex(e => e.Url).IsUnique(); });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}