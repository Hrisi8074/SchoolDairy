using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Common.DataConstants.Teacher;
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
        [MaxLength(FirstNameTeachertMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MiddleNameTeacherMaxLenght)]
        public string MiddleName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameTeacherMaxLenght)]
        public string LastName { get; set; } = null!;

        [Required]
        public string EmailAddres { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        public string ClassTeacher { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }


    }
}
