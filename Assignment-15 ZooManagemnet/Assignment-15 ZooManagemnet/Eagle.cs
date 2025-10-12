using System;

/// <summary>
/// Represents an eagle, derived from Bird.
/// </summary>
public class Eagle : Bird
{
    public Eagle(string name, int age, double wingSpan)
        : base(name, age, wingSpan) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} screeches powerfully!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Eagle: {Name}, Age: {Age}, Wingspan: {WingSpan} ft");
    }
}
