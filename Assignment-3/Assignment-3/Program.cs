using System;

// Building a Personal Information collector 
//Name, Age, city, favroite hobby
//Using the above information display a summary using string interpolation

namespace Assignment_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Frist Name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            string lName = Console.ReadLine();

            Console.WriteLine("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter which city are you from?");
            string city = Console.ReadLine();

            Console.WriteLine("Enter your Favroite Hobby: ");
            string hobby = Console.ReadLine();

            int currentTime = DateTime.Now.Year;
            int birthAge = currentTime - age;


            Console.WriteLine($"------------Summary of Personal Information-----------");
            Console.WriteLine();
            Console.Write($"{fName} {lName} is a {age} years old individual from {city}. ");
            Console.Write($"{fName} is passionate about {hobby} and enjoy the free time doing it. ");
            Console.Write($"Based on the given age, {fName} is likey {birthAge}.");
            Console.WriteLine() ;
        }

    }
}

