using System.ComponentModel.DataAnnotations;
using SchoolDairy.Data.Enums;
using static SchoolDairy.Data.DataConstants.Student;

namespace SchoolDairy.Data.Models
{
    public class Student
    {
        
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
        public string Classroom { get; set; } = null!;

        [Required]
        public int Number { get; set; }

        [Required]
         public string FormOfTraining { get; set; } = null!;

        [Required]
        public Speciality Specialty { get; set; }

        public int ParentId { get; set; }

        public virtual Parent Parent { get; set; } = null!;

        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;


        public int GradesId { get; set; }

        public virtual Grades Grades{ get; set; } = null!;

    }
}
