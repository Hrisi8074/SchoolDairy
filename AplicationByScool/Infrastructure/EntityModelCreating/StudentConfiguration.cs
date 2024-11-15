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
          
        }
       

    }
}
