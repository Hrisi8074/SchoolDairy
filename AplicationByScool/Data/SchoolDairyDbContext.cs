
namespace SchoolDairy.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SchoolDairy.Data.Models;
    using SchoolDairy.Infrastructure.EntityModelCreating;

    public class SchoolDairyDbContext : IdentityDbContext<IdentityUser>
    {
        public SchoolDairyDbContext()
        {

        }
        public SchoolDairyDbContext(DbContextOptions<SchoolDairyDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; } 

        public DbSet<Grades> Grades { get; set; } 

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectGrades> SubjectGrades { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GradesConfiguration());
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectGradesConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
           

            base.OnModelCreating(modelBuilder);
        }
    }
}
