using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Infrastructure.EntityModelCreating
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
           

            builder.HasOne(s=>s.Teacher)
                .WithMany(s => s.Students)
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.Parent)
              .WithMany(s => s.Students)
              .HasForeignKey(s => s.ParentId)
              .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasIndex(s => s.Classroom)
                .IsUnique();
           builder
                .HasIndex(s=>s.Number)
                .IsUnique();
            builder
                .HasIndex(s=>s.Specialty)
                .IsUnique();
            builder.HasData(this.GenerateStudent());
        }
        private IEnumerable<Student> GenerateStudent()
        {
            IEnumerable<Student> students = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Ivan",
                    MiddleName = "Petrov",
                    LastName = "Petrov",
                    Classroom = "11",
                    Number = (int) 9,
                    FormOfTraining = "Day",
                    Specialty = (Data.Enums.Speciality) 1,
                },
               new Student()
                {

                    FirstName = "Ivanka",
                    MiddleName = "Zheleva",
                    LastName = "Pekova",
                    Classroom = "10",
                    Number = (int) 10,
                    FormOfTraining = "Day",
                    Specialty = (Data.Enums.Speciality) 2,


                },
                new Student()
                {
                    FirstName = "Zlatan",
                    MiddleName = "Tihomirov",
                    LastName = "Hristov",
                    Classroom = "9",
                    Number = (int) 12,
                    FormOfTraining = "Day",
                    Specialty = (Data.Enums.Speciality) 3,
                },
            };
            return students;
        }

    }
}
