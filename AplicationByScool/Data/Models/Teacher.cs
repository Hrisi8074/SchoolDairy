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
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameStudentMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MiddleNameStudentMaxLenght)]
        public string MiddleName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameStudentMaxLenght)]
        public string LastName { get; set; } = null!;

        [Required]
        public string EmailAddres { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        public string ClassTeacher { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
      
       
    }
}
