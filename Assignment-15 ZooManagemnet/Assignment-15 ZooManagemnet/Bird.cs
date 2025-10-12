using System;

/// <summary>
/// Represents a general bird derived from Animal.
/// </summary>
public class Bird : Animal
{
    public double WingSpan { get; set; }

    public Bird(string name, int age, double wingSpan) : base(name, age)
    {
        WingSpan = wingSpan;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} chirps softly.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Bird: {Name}, Age: {Age}, Wingspan: {WingSpan} ft");
    }
}
