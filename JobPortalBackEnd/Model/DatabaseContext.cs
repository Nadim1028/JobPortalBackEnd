using Microsoft.EntityFrameworkCore;

namespace JobPortalBackEnd.Model
{
    public class DatabaseContext : DbContext
    {
        private const string ConnectionString = @"Server=LAPTOP-52JJODEV;Database=JobPortalDB;Trusted_Connection=true";

        public DbSet<Student> Students { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobSeekerAuth> JobSeekerAuthTable { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<EmployerAuth> EmployerAuthTable { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
