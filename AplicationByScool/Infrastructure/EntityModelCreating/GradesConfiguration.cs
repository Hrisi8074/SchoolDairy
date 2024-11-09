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
                .HasOne(g=>g.Subject)
                .WithMany(g=>g.Grades)
                .HasForeignKey(g=>g.GradesId)
                .OnDelete(DeleteBehavior.Restrict);

           
        }
    }
}
