using Assignment_25.Models;
using System.Collections.Generic;

namespace Assignment_25.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
