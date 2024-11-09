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
                .HasIndex(t => t.Email)
                .IsUnique();
            builder
                .HasIndex(t => t.ClassTeacher)
                .IsUnique();

        }
    }
}
