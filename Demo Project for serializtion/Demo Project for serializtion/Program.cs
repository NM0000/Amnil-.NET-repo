using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerializationDemo
{
    /// <summary>
    /// Represents a student with ID, Name, and Grade.
    /// This class will be serialized into JSON.
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Grade { get; set; }
    }

    class Program
    {
        private const string FilePath = "students.json"; // File to store JSON data

        static void Main()
        {
            // 1️⃣ Create some sample student data
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nishil", Grade = 88.5 },
                new Student { Id = 2, Name = "Tushar", Grade = 92.3 },
                new Student { Id = 3, Name = "Dipa", Grade = 79.8 }
            };

            // 2️⃣ Serialize (convert) the list to JSON string
            string jsonData = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });

            // 3️⃣ Save the JSON string into a file
            File.WriteAllText(FilePath, jsonData);
            Console.WriteLine("✅ Data has been serialized and saved to 'students.json'.\n");

            // 4️⃣ Display the serialized JSON content
            Console.WriteLine("Serialized JSON Data:");
            Console.WriteLine(jsonData);
            Console.WriteLine();

            // 5️⃣ Deserialize (read) JSON back to a List<Student> object
            string readJson = File.ReadAllText(FilePath);
            List<Student>? loadedStudents = JsonSerializer.Deserialize<List<Student>>(readJson);

            // 6️⃣ Display the deserialized data
            Console.WriteLine("Deserialized Data (Objects):");
            foreach (var s in loadedStudents!)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Grade: {s.Grade}");
            }

            Console.WriteLine("\n✅ Deserialization complete!");
        }
    }
}
