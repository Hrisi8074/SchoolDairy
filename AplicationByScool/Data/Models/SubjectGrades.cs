namespace SchoolDairy.Data.Models
{
    public class SubjectGrades
    {
        public int SubjectId { get; set; }

        public int GradeId { get; set; }

        public virtual Subject Subject { get; set; } = null!;

        public virtual Grades Grades { get; set; } = null!;
    }
}
