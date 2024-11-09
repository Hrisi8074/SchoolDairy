using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Subject
    {

        public Subject()
        {
            SubjectGrades = new HashSet<SubjectGrades>();
            Grades = new HashSet<Grades>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public Student Student { get; set; } = null!;

        public int StudentId { get; set; } 

        public virtual Teacher Teacher { get; set; } = null!;

        public int TeacherId { get; set; }

       
        public virtual ICollection<Grades> Grades { get; set; }
        public virtual ICollection<SubjectGrades> SubjectGrades { get; set; }
    }
}
