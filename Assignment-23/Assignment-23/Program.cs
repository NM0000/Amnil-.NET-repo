using System;
using System.Data.SQLite;

namespace Assignment_23
{
    class Program
    {
        static string dbPath = "Data Source=school.db;";

        static void Main()
        {
            CreateTables();
            InsertStudent("Nishil", 20, "12", "nishil@example.com");
            InsertStudent("Biraj", 19, "11", "biraj@example.com");
            InsertCourse("Mathematics", "Dr. Sharma", 4);
            InsertCourse("Computer Science", "Prof. Gurung", 3);

            Console.WriteLine("\n--- Initial Data ---");
            ReadStudents();
            ReadCourses();

            UpdateStudentEmail(1, "nishil.maharjan@school.com");
            DeleteCourse(2);

            Console.WriteLine("\n--- After Update/Delete ---");
            ReadStudents();
            ReadCourses();
        }

        // Create Tables
        static void CreateTables()
        {
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();

                string createStudents = @"
                    CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Age INTEGER,
                        GradeLevel TEXT,
                        Email TEXT
                    );";

                string createCourses = @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL,
                        InstructorName TEXT,
                        Credits INTEGER
                    );";

                using (var cmd1 = new SQLiteCommand(createStudents, connection))
                    cmd1.ExecuteNonQuery();

                using (var cmd2 = new SQLiteCommand(createCourses, connection))
                    cmd2.ExecuteNonQuery();

                Console.WriteLine("Tables created (if not exist).");
            }
        }

        // Insert Student Data
        static void InsertStudent(string name, int age, string gradeLevel, string email)
        {
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string sql = "INSERT INTO Students (Name, Age, GradeLevel, Email) VALUES (@name, @age, @grade, @email);";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@grade", gradeLevel);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine($"Inserted Student: {name}");
            }
        }

        // Insert Course Data
        static void InsertCourse(string courseName, string instructor, int credits)
        {
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string sql = "INSERT INTO Courses (CourseName, InstructorName, Credits) VALUES (@cname, @instructor, @credits);";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@cname", courseName);
                    cmd.Parameters.AddWithValue("@instructor", instructor);
                    cmd.Parameters.AddWithValue("@credits", credits);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine($"Inserted Course: {courseName}");
            }
        }

        // Read All Students
        static void ReadStudents()
        {
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string sql = "SELECT * FROM Students;";
                using (var cmd = new SQLiteCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n--- Students ---");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["StudentID"]}: {reader["Name"]}, Age: {reader["Age"]}, Grade: {reader["GradeLevel"]}, Email: {reader["Email"]}");
                    }
                }
            }
        }

        // Read All Courses
        static void ReadCourses()
        {
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string sql = "SELECT * FROM Courses;";
                using (var cmd = new SQLiteCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n--- Courses ---");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["CourseID"]}: {reader["CourseName"]} | {reader["InstructorName"]} | Credits: {reader["Credits"]}");
                    }
                }
            }
        }

        // Update Student Email
        static void UpdateStudentEmail(int id, string newEmail)
        {
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string sql = "UPDATE Students SET Email = @email WHERE StudentID = @id;";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@email", newEmail);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine($"Updated Student ID {id} email.");
            }
        }

        // Delete Course
        static void DeleteCourse(int id)
        {
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string sql = "DELETE FROM Courses WHERE CourseID = @id;";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine($"Deleted Course ID {id}.");
            }
        }
    }
}
