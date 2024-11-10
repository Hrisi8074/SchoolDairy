using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Infrastructure.EntityModelCreating
{
    public class GradesConfiguration : IEntityTypeConfiguration<Grades>
    {
        public void Configure(EntityTypeBuilder<Grades> builder)
        {
           builder
                .HasOne(g=>g.Student)
                .WithMany(g=>g.Gradeses)
                .HasForeignKey(g=>g.Id)
                .OnDelete(DeleteBehavior.Restrict);

           
        }
    }
}
