
namespace SchoolDairy.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SchoolDairy.Data.Models;

    public class SchoolDairyDbContext : IdentityDbContext
    {
        public SchoolDairyDbContext(DbContextOptions<SchoolDairyDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Grades> Grades { get; set; }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectGrades> SubjectGrades { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
