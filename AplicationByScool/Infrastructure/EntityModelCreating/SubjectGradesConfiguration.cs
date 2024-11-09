using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Infrastructure.EntityModelCreating
{
    public class SubjectGradesConfiguration : IEntityTypeConfiguration<SubjectGrades>
    {
        public void Configure(EntityTypeBuilder<SubjectGrades> builder)
        {
            builder
                .HasKey(sg => new {sg.SubjectId,sg.GradeId});
        }
    }
}
