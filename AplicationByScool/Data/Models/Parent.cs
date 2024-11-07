using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Data.DataConstants.Parent;

namespace SchoolDairy.Data.Models
{
    public class Parent
    {
        public Parent()
        {
            Teachers = new List<Teacher>();
        }

        public int Id { get; set; }

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

        public virtual Student Student { get; set; }

        public int StudentId { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

    }
}
