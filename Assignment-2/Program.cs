using System;
using System.Collections.Generic;

namespace Assignment_2
{
  class Program
  {
    static void Main(string[] args)
    {
      //Declearing variables

      //Integer variable declaration
      int age = 20;

      //Double variable declaration
      double GPA = 3.55;

      //String variable declaration
      string name = "Nishil Maharjan";

      //Char variable declaration
      char grade = 'A';

      //Boolean variable declaration
      bool isGraduated = false;

      //Date and time variable declaration
      DateTime currentDate = DateTime.Now;

      //Calculating and display age in days

      //my birthdate is December 15, 2002
      DateTime birthDate = new DateTime(2002, 12, 15);

      //difference between current date and birthdate
      TimeSpan ageInDays = currentDate - birthDate;

      int ageDifference = ageInDays.Days;

      //Result is
      Console.WriteLine($"Brith Date: {birthDate.ToShortDateString()}");

      Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");

      Console.WriteLine($"Age in Days: {ageDifference} days");

      // Display student information
      Console.WriteLine("=== STUDENT INFORMATION ===");

      Console.WriteLine($"Name: {name}");

      Console.WriteLine($"Age: {age} years");

      Console.WriteLine($"Grade: {grade}");

      Console.WriteLine($"GPA: {GPA:F2}"); //Format to 2 decimal places
      
      Console.WriteLine($"Graduated: {isGraduated}");
      
    }
  }
}
