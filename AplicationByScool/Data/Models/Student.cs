using System.ComponentModel.DataAnnotations;
using SchoolDairy.Data.Enums;
using static SchoolDairy.Data.DataConstants.Student;

namespace SchoolDairy.Data.Models
{
    public class Student
    {
        public Student()
        {
            Gradeses = new List<Grades>(); 
        }
        [Key]
        public int Id { get; set; }

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
        public string Classroom { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
         public string FormOfTraining { get; set; } 

        [Required]
        public Speciality Specialty { get; set; }

        public int ParentId { get; set; }

        public virtual Parent Parent { get; set; }
        public virtual ICollection<Grades> Gradeses { get; set; }

    }
}
