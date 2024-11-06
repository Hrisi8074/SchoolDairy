using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }



        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
    }
}
