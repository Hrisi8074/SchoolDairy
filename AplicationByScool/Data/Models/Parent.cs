using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Data.DataConstants.Parent;

namespace SchoolDairy.Data.Models
{
    public class Parent
    {
        public Parent()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int ParentId { get; set; }

        [Required]
        [MaxLength(FirstNameParentMaxLenght)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(LastNameParentMaxLenght)]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public string? UserName { get; set; }

        public string? Gender { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
