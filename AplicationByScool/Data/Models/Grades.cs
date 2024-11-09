using SchoolDairy.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Grades
    {
    public Grades()
        {
           
            SubjectGrades = new HashSet<SubjectGrades>();
        }
        [Key]
        public int GradesId { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]

        public TypeGrades Type { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public DateTime Introduced { get; set; }
       
        public virtual ICollection<SubjectGrades> SubjectGrades { get; set; }
    }
}
