using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Infrastructure.EntityModelCreating
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
        
            builder
                  .HasIndex(t => t.PhoneNumber)
                  .IsUnique();
            builder
                .HasIndex(t => t.EmailAddress)
                .IsUnique();
            builder
                .HasIndex(t => t.ClassTeacher)
                .IsUnique();

        }
        private IEnumerable<Teacher> GenerateTeacher()
        {
            IEnumerable<Teacher> teachers = new List<Teacher>()
            {
                new Teacher()
                {
                    FirstName = "Tina",
                    MiddleName = "Boilova",
                    LastName = "Boilova",
                    EmailAddress = "bilova@321su.edu.mon",
                    PhoneNumber = "+35959874135",
                    ClassTeacher = "10G"
                },
                new Teacher()
                {
                   FirstName = "Todor",
                    MiddleName = "Todorov",
                    LastName = "Stoilov",
                    EmailAddress = "tstoilov@321su.edu.mon",
                    PhoneNumber = "+359563214855",
                    ClassTeacher = "11B"
                },
                new Teacher()
                {
                   FirstName = "Tihomir",
                    MiddleName = "Tihomirov",
                    LastName = "Petrov",
                    EmailAddress = "tpetrov@321su.edu.mon",
                    PhoneNumber = "+359913648235",
                    ClassTeacher = "9A"
                }
            };
            return teachers;
        }
    }
}
