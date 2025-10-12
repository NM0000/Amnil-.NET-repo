using System;

/// <summary>
/// Represents a crocodile, derived from Reptile.
/// </summary>
public class Crocodile : Reptile
{
    public Crocodile(string name, int age, bool isVenomous) : base(name, age, isVenomous) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} growls from the water!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Crocodile: {Name}, Age: {Age}, Venomous: {(IsVenomous ? "Yes" : "No")}");
    }
}
