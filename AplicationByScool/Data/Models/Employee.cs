using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Data.DataConstants.Employee;

namespace SchoolDairy.Data.Models
{
    public class Employee
    {
        public Employee()
        {
           Teachers = new HashSet<Teacher>();
           Students = new HashSet<Student>(); 
        }
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(FirstNameEmployeeMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameEmployeeMaxLenght)]
        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
