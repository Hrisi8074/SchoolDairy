using Microsoft.EntityFrameworkCore;
using SchoolDairy.Data.Model.Enums;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Data.Seed
{
    public static class SeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>()
                .HasData(
                     new Parent
                     {
                         Id = 1,
                         FirstName = "Ivelina",
                         LastName = "Petrova",
                         PhoneNumber = "+359123654789",
                         EmailAddres = "ivaptrova@abv.bg"
                     },
                     new Parent
                     {
                         Id = 2,
                         FirstName = "Petar",
                         LastName = "Ivanov",
                         PhoneNumber = "+359987456321",
                         EmailAddres = "ivanov@abv.bg"
                     },
                     new Parent
                     {
                         Id = 3,
                         FirstName = "Hristo",
                         LastName = "Hristov",
                         PhoneNumber = "+359456981234",
                         EmailAddres = "hhistov@abv.bg"
                     });



            modelBuilder.Entity<Teacher>()
               .HasData(
                    new Teacher
                    {
                        Id = 1,
                        FirstName = "Tina",
                        MiddleName = "Boilova",
                        LastName = "Boilova",
                        EmailAddres = "bilova@321su.edu.mon",
                        PhoneNumber = "+35959874135",
                        ClassTeacher = "10G"
                    },
                    new Teacher
                    {
                        Id = 2,
                        FirstName = "Todor",
                        MiddleName = "Todorov",
                        LastName = "Stoilov",
                        EmailAddres = "tstoilov@321su.edu.mon",
                        PhoneNumber = "+359563214855",
                        ClassTeacher = "11B"
                    },
                    new Teacher
                    {
                        Id = 3,
                        FirstName = "Tihomir",
                        MiddleName = "Tihomirov",
                        LastName = "Petrov",
                        EmailAddres = "tpetrov@321su.edu.mon",
                        PhoneNumber = "+359913648235",
                        ClassTeacher = "9A"
                    });
            modelBuilder.Entity<Student>()
              .HasData(
                   new Student
                   {
                       Id = 1,
                       ParentId = 1,
                       FirstName = "Ivanka",
                       MiddleName = "Zheleva",
                       LastName = "Pekova",
                       Classroom = "10",
                       Number = 10,
                       FormOfTraining = "Day",
                       Specialty = (Speciality)2,
                       TeacherId = 1,
                   },
                   new Student
                   {
                       Id = 2,
                       ParentId = 2,
                       FirstName = "Lubo",
                       MiddleName = "Lubomirov",
                       LastName = "Lubomirov",
                       Classroom = "8",
                       Number = 14,
                       FormOfTraining = "Day",
                       Specialty = (Speciality)3,
                       TeacherId = 2,
                   },
                    new Student
                    {
                        Id = 3,
                        ParentId = 3,
                        FirstName = "Zlatan",
                        MiddleName = "Tihomirov",
                        LastName = "Hristov",
                        Classroom = "9",
                        Number = 12,
                        FormOfTraining = "Day",
                        Specialty = (Speciality)1,
                        TeacherId = 3,
                    });


        }
    }
}

