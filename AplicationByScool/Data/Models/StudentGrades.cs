namespace SchoolDairy.Data.Models
{
    public class StudentGrades
    {
        public int StudentId { get; set; }

        public virtual Student Student { get; set; } = null!;
        public int GradesId { get; set; }
        public virtual Grades Grades { get; set; } = null!;
    }
}
