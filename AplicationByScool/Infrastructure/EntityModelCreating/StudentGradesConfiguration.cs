using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Infrastructure.EntityModelCreating
{
    public class StudentGradesConfiguration : IEntityTypeConfiguration<StudentGrades>
    {
        public void Configure(EntityTypeBuilder<StudentGrades> builder)
        {
            builder.HasKey(sg => new {sg.StudentId,sg.GradesId});
            builder
              .HasOne(sg=>sg.Grades)
              .WithMany(sg=>sg.StudentGrades)
              .HasForeignKey(sg=>sg.GradesId);

            builder
             .HasOne(sg => sg.Student)
             .WithMany(sg => sg.StudentGrades)
             .HasForeignKey(sg => sg.StudentId);
        }
    }
}
