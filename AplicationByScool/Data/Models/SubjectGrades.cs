namespace SchoolDairy.Data.Models
{
    public class SubjectGrades
    {
        public virtual Subject Subject { get; set; }

        public int SubjectId { get; set; }

        public virtual Grades Grades { get; set; }

        public int GradeId { get; set; }
    }
}
