using System;

/// <summary>
/// Represents a general mammal derived from Animal.
/// </summary>
public class Mammal : Animal
{
    public string FurColor { get; set; }

    public Mammal(string name, int age, string furColor) : base(name, age)
    {
        FurColor = furColor;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} makes a generic mammal sound.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Mammal: {Name}, Age: {Age}, Fur Color: {FurColor}");
    }
}
