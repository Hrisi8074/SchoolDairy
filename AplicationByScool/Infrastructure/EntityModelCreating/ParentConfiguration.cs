using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using SchoolDairy.Data.Models;
using System.Net.Mail;

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
                .HasIndex(t => t.EmailAddres)
                .IsUnique();
           

        }
        
    }
}
