using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]

        public string PhoneNumber { get; set; }

        public string ClassTeacher { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();






    }
}
