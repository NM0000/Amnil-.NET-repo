using System;

/// <summary>
/// Represents a general reptile derived from Animal.
/// </summary>
public class Reptile : Animal
{
    public bool IsVenomous { get; set; }

    public Reptile(string name, int age, bool isVenomous) : base(name, age)
    {
        IsVenomous = isVenomous;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} makes a hissing sound.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Reptile: {Name}, Age: {Age}, Venomous: {(IsVenomous ? "Yes" : "No")}");
    }
}
