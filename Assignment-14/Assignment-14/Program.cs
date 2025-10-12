using System;

namespace Assignment14
{
    // 1. ANIMAL INHERITANCE HIERARCHY

    /// <summary>
    /// Base class representing a generic animal.
    /// </summary>
    class Animal
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Constructor to initialize animal details.
        /// </summary>
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Virtual method to make a sound. Can be overridden by derived classes.
        /// </summary>
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    /// <summary>
    /// Dog class derived from Animal.
    /// </summary>
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        /// <summary>
        /// Overrides MakeSound method for Dog.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Dog) says: Woof! Woof!");
        }
    }

    /// <summary>
    /// Cat class derived from Animal.
    /// </summary>
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        /// <summary>
        /// Overrides MakeSound method for Cat.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Cat) says: Meow!");
        }
    }

    /// <summary>
    /// Bird class derived from Animal.
    /// </summary>
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        /// <summary>
        /// Overrides MakeSound method for Bird.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Bird) says: Tweet! Tweet!");
        }
    }

    // 2. SHAPE INHERITANCE HIERARCHY

    /// <summary>
    /// Base class for different geometric shapes.
    /// </summary>
    abstract class Shape
    {
        /// <summary>
        /// Abstract method to calculate area (must be overridden).
        /// </summary>
        public abstract double GetArea();

        /// <summary>
        /// Abstract method to calculate perimeter (must be overridden).
        /// </summary>
        public abstract double GetPerimeter();
    }

    /// <summary>
    /// Rectangle class derived from Shape.
    /// </summary>
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }

    /// <summary>
    /// Circle class derived from Shape.
    /// </summary>
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // MAIN PROGRAM

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Animal Hierarchy ===");

            Animal dog = new Dog("Buddy", 3);
            Animal cat = new Cat("Whiskers", 2);
            Animal bird = new Bird("Chirpy", 1);

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();

            Console.WriteLine("\n=== Shape Hierarchy ===");

            Shape rectangle = new Rectangle(5, 3);
            Shape circle = new Circle(4);

            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.GetPerimeter()}");

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Circle Perimeter: {circle.GetPerimeter():F2}");
        }
    }
}