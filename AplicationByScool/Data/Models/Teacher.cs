using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Data.DataConstants.Student;
namespace SchoolDairy.Data.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int TeacherId { get; set; }

        [Required]
        [MaxLength(FirstNameStudentMaxLenght)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(MiddleNameStudentMaxLenght)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(LastNameStudentMaxLenght)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string ClassTeacher { get; set; }

       public virtual ICollection<Student> Students { get; set; }
      
       
    }
}
