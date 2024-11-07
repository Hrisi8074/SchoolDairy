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

        public int Id { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]

        public TypeGrades Type { get; set; }

        public DateTime Introduced {  get; set; }

        public virtual Teacher Teachers { get; set; }

        public int TeacherId { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
