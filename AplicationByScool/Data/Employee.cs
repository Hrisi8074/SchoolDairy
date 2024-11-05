using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;
        public virtual ICollection<Teacher> Teachers { get; set} = new HashSet<Teacher>();
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();



    }
}
