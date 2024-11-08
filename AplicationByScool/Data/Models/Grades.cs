using SchoolDairy.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Grades
    {
 public Grades()
        {
            Subjects = new List<Subject>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]

        public TypeGrades Type { get; set; }

        public DateTime Introduced {  get; set; }

        public virtual Teacher Teacher { get; set; }

        public int TeacherId { get; set; }

        public virtual Student Student { get; set; }

        public int StudentId { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
