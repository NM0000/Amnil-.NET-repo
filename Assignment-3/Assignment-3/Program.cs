using System;
using System.Xml.Linq;

// Building a Personal Information collector 
//Name, Age, city, favroite hobby
//Using the above information display a summary using string interpolation

namespace Assignment_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Personal Information Collector ----\n");

            // Collect full name
            (string fName, string lName) = GetFullName();

            // Collect personal details
            (int age, string city, string hobby) = GetPersonalInfo();

            // Calculate birth year
            int birthYear = DateTime.Now.Year - age;

            // Display formatted summary
            DisplaySummary(fName, lName, age, city, hobby, birthYear);
        }

        static (string, string) GetFullName()
        {
            Console.Write("Enter your Frist Name: ");
            string fNameInput = Console.ReadLine();
            string fName = char.ToUpper(fNameInput[0]) + fNameInput.Substring(1).ToLower(); ;

            Console.Write("Enter your Last Name: ");
            string lNameInput = Console.ReadLine();
            string lName = char.ToUpper(lNameInput[0]) + lNameInput.Substring(1).ToLower();

            return (fName, lName);  
        }

        static (int, string, string) GetPersonalInfo()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your city: ");
            string cityInput = Console.ReadLine();
            string city = char.ToUpper(cityInput[0]) + cityInput.Substring(1).ToLower(); 

            Console.Write("Enter your favroite hobby: ");
            string hobby = Console.ReadLine();


            return (age, city, hobby);
        }

        static void DisplaySummary(string fName, string lName, int age, string city, string hobby, int birthAge)
        {
            Console.WriteLine($"------------Summary of Personal Information-----------");
            Console.WriteLine();
            Console.Write($"{fName} {lName} is a {age} years old individual from {city}. ");
            Console.Write($"{fName} is passionate about {hobby} and enjoy the free time doing it. ");
            Console.Write($"Based on the given age, {fName} is likey born in {birthAge}.");
            Console.WriteLine();
        }

    }
}

