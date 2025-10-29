using System.ComponentModel.DataAnnotations;

namespace Assignment_24
{
    /// <summary>
    /// Represents a student record in the database.
    /// </summary>
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Course { get; set; }
    }
}
