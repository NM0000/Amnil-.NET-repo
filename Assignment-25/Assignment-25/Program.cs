using System;
using System.Linq;
using Assignment_25.Models;

namespace Assignment_25
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new StudentDbContext();

            // create database & apply any pending migrations (if using migrations)
            context.Database.EnsureCreated();

            // Seed data if empty
            if (!context.Students.Any())
            {
                var s1 = new Student { Name = "Ritika" };
                var s2 = new Student { Name = "Nikita" };
                var s3 = new Student { Name = "Binita" };

                var c1 = new Course { Title = "Mathematics" };
                var c2 = new Course { Title = "Physics" };
                var c3 = new Course { Title = "Computer Science" };

                context.Students.AddRange(s1, s2, s3);
                context.Courses.AddRange(c1, c2, c3);
                context.SaveChanges();

                // enrollments (StudentCourse)
                context.StudentCourses.AddRange(
                    new StudentCourse { StudentId = s1.StudentId, CourseId = c1.CourseId },
                    new StudentCourse { StudentId = s1.StudentId, CourseId = c3.CourseId },
                    new StudentCourse { StudentId = s2.StudentId, CourseId = c1.CourseId },
                    new StudentCourse { StudentId = s2.StudentId, CourseId = c2.CourseId },
                    new StudentCourse { StudentId = s3.StudentId, CourseId = c3.CourseId }
                );

                // grades
                context.Grades.AddRange(
                    new Grade { StudentId = s1.StudentId, CourseId = c1.CourseId, Score = 3.7 },
                    new Grade { StudentId = s1.StudentId, CourseId = c3.CourseId, Score = 3.9 },
                    new Grade { StudentId = s2.StudentId, CourseId = c1.CourseId, Score = 3.5 },
                    new Grade { StudentId = s2.StudentId, CourseId = c2.CourseId, Score = 3.8 },
                    new Grade { StudentId = s3.StudentId, CourseId = c3.CourseId, Score = 4.0 }
                );

                context.SaveChanges();
            }

            // --- Queries ---

            // 1) Students enrolled in a specific course (by title)
            string courseTitle = "Mathematics";
            var studentsInCourse = context.StudentCourses
                .Where(sc => sc.Course.Title == courseTitle)
                .Select(sc => sc.Student.Name)
                .Distinct()
                .ToList();

            Console.WriteLine($"Students enrolled in {courseTitle}:");
            studentsInCourse.ForEach(n => Console.WriteLine($" - {n}"));

            // 2) Average grades per course
            var avgGrades = context.Grades
                .GroupBy(g => g.Course.Title)
                .Select(g => new
                {
                    Course = g.Key,
                    AverageGrade = g.Average(x => x.Score)
                })
                .ToList();

            Console.WriteLine("\nAverage Grades per Course:");
            foreach (var item in avgGrades)
                Console.WriteLine($"{item.Course}: {item.AverageGrade:F2}");

            // 3) Students with highest GPA (average of their grades)
            var topStudents = context.Grades
                .GroupBy(g => g.Student.Name)
                .Select(g => new
                {
                    Student = g.Key,
                    GPA = g.Average(x => x.Score)
                })
                .OrderByDescending(x => x.GPA)
                .ToList();

            Console.WriteLine("\nStudents sorted by GPA:");
            topStudents.ForEach(t => Console.WriteLine($"{t.Student}: {t.GPA:F2}"));

            Console.WriteLine("\nDone. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
