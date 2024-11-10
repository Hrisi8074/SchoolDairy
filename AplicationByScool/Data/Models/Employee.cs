using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Data.DataConstants.Employee;

namespace SchoolDairy.Data.Models
{
    public class Employee
    {
       
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameEmployeeMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameEmployeeMaxLenght)]
        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;
       
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
    }
}
