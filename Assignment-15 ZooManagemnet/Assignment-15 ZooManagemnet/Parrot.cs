using System;

/// <summary>
/// Represents a parrot, derived from Bird.
/// </summary>
public class Parrot : Bird
{
    public bool CanTalk { get; set; }

    public Parrot(string name, int age, double wingSpan, bool canTalk)
        : base(name, age, wingSpan)
    {
        CanTalk = canTalk;
    }

    public override void MakeSound()
    {
        if (CanTalk)
            Console.WriteLine($"{Name} says: 'Hello!'");
        else
            Console.WriteLine($"{Name} squawks!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Parrot: {Name}, Age: {Age}, Can Talk: {(CanTalk ? "Yes" : "No")}");
    }
}
