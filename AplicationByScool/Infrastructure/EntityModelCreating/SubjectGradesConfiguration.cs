using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolDairy.Data.Models;
using System.Reflection.Emit;

namespace SchoolDairy.Infrastructure.EntityModelCreating
{
    public class SubjectGradesConfiguration : IEntityTypeConfiguration<SubjectGrades>
    {
        
            public void Configure(EntityTypeBuilder<SubjectGrades> builder)
            {
            builder
          .HasKey(sd => new { sd.SubjectId, sd.GradeId });

            builder
                .HasOne(sd => sd.Grades)
                .WithMany(sd => sd.SubjectGrades)
                .HasForeignKey(sd => sd.GradeId);

            builder
                .HasOne(sd => sd.Subject)
                .WithMany(sd => sd.SubjectGrades)
                .HasForeignKey(sd => sd.SubjectId);
        }
        
    }
}
