using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string MiddleName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Email { get; set; }

        [Required]

        public string PhoneNumber { get; set; } = null!;

        public string ClassTeacher { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();






    }
}
