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
                .HasIndex(t => t.EmailAddress)
                .IsUnique();
            builder.HasData(this.GenerateParent());

        }
        private IEnumerable<Parent> GenerateParent()
        {
            IEnumerable<Parent> parents = new List<Parent>()
            {
                new Parent()
                {
                    FirstName = "Ivelina",
                    LastName = "Petrova",
                    PhoneNumber = "+359123654789",
                    EmailAddress = "ivaptrova@abv.bg"
                },
                new Parent()
                {
                    FirstName = "Petar",
                    LastName = "Ivanov",
                    PhoneNumber = "+359987456321",
                    EmailAddress = "ivanov@abv.bg"
                },
                new Parent()
                {
                    FirstName = "Hristo",
                    LastName = "Hristov",
                    PhoneNumber = "+359456981234",
                    EmailAddress = "hhistov@abv.bg"
                }
            };
            return parents; 
        }
    }
}
