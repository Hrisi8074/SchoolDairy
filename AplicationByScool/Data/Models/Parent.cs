using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Data.DataConstants.Parent;

namespace SchoolDairy.Data.Models
{
    public class Parent
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameParentMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameParentMaxLenght)]
        public string LastName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        public string? UserName { get; set; }

        public string? Gender { get; set; }


       
    }
}
