
namespace SchoolDairy.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using SchoolDairy.Data.Seed;
    using SchoolDairy.Data.Models;
    using SchoolDairy.Infrastructure.EntityModelCreating;

    public class SchoolDairyDbContext : IdentityDbContext<IdentityUser>
    {
        public SchoolDairyDbContext()
        {

        }
        public SchoolDairyDbContext(DbContextOptions<SchoolDairyDbContext> options) : base(options) { }

        public DbSet<Grades> Grades { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentGrades> StudentGrades { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new StudentGradesConfiguration());

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
