using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string MiddleName { get; set; } = null!;

        [Required]

        public string LastName { get; set; } = null!;

        [Required]

        public string Classroom { get; set; } = null!;

        [Required]

        public int Number { get; set; }

        [Required]

        public string FormOfTraining { get; set; } = null!;

        [Required]
        public string Specialty { get; set; } = null!;

        public virtual ICollection<Parent> Parents { get; set; } = new HashSet<Parent>();

        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();

    }
}
