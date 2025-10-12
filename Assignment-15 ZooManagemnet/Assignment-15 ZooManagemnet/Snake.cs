using System;

/// <summary>
/// Represents a snake, derived from Reptile.
/// </summary>
public class Snake : Reptile
{
    public Snake(string name, int age, bool isVenomous) : base(name, age, isVenomous) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} hisses sss!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Snake: {Name}, Age: {Age}, Venomous: {(IsVenomous ? "Yes" : "No")}");
    }
}
