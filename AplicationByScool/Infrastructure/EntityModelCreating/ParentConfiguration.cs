using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Infrastructure.EntityModelCreating
{
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder
                 .HasIndex(t => t.PhoneNumber)
                 .IsUnique();
            builder
                .HasIndex(t => t.Email)
                .IsUnique();

        }   
    }
}
