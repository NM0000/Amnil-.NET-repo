using System;
using System.Linq;

namespace Assignment_24
{
    class Program
    {
        static void Main()
        {
            using var db = new StudentDbContext();
            db.Database.EnsureCreated();

            while (true)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student by Name");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddStudent(db); break;
                    case "2": ViewAll(db); break;
                    case "3": SearchStudent(db); break;
                    case "4": UpdateStudent(db); break;
                    case "5": DeleteStudent(db); break;
                    case "6": return;
                    default: Console.WriteLine("Invalid choice."); break;
                }
            }
        }

        static void AddStudent(StudentDbContext db)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            db.Students.Add(new Student { Name = name, Age = age, Course = course });
            db.SaveChanges();
            Console.WriteLine("Student added successfully!");
        }

        static void ViewAll(StudentDbContext db)
        {
            var students = db.Students.ToList();
            Console.WriteLine("\n--- Student List ---");
            foreach (var s in students)
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Course: {s.Course}");
        }

        static void SearchStudent(StudentDbContext db)
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();
            var results = db.Students.Where(s => s.Name.Contains(name)).ToList();

            if (results.Any())
                results.ForEach(s => Console.WriteLine($"ID: {s.Id}, {s.Name} - {s.Course}, {s.Age}"));
            else
                Console.WriteLine("No student found.");
        }

        static void UpdateStudent(StudentDbContext db)
        {
            Console.Write("Enter student ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var student = db.Students.Find(id);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter new name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter new age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter new course: ");
            student.Course = Console.ReadLine();

            db.SaveChanges();
            Console.WriteLine("Student updated successfully!");
        }

        static void DeleteStudent(StudentDbContext db)
        {
            Console.Write("Enter student ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            var student = db.Students.Find(id);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            db.Students.Remove(student);
            db.SaveChanges();
            Console.WriteLine("Student deleted successfully!");
        }
    }
}
