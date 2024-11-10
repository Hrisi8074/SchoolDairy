using SchoolDairy.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Grades
    {

        public Grades()
        {
           
            StudentGrades = new HashSet<StudentGrades>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]

        public TypeGrades Type { get; set; }

      

     
        public DateTime Introduced { get; set; }

       

        public virtual ICollection<StudentGrades> StudentGrades { get; set; }
    }
}
