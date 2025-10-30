namespace Assignment_25.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public double Score { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
