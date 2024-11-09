namespace SchoolDairy.Data.Models
{
    public class SubjectGrades
    {
        public virtual Subject Subject { get; set; } = null!;

        public int SubjectId { get; set; }

        public virtual Grades Grades { get; set; } = null!;

        public int GradeId { get; set; }
    }
}
