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
        public int Id { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]

        public TypeGrades Type { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; } = null!;

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; } = null!;
        public DateTime Introduced { get; set; }
       
        public virtual ICollection<SubjectGrades> SubjectGrades { get; set; }
    }
}
