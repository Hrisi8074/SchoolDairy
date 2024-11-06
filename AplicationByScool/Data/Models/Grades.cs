using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Grades
    {
        public int Id { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]

        public string Type { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
    }
}
