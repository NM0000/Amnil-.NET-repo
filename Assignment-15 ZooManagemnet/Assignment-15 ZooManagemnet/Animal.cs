using System;

/// <summary>
/// Abstract base class representing a general animal.
/// </summary>
public abstract class Animal
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract methods to be implemented by derived classes
    public abstract void MakeSound();
    public abstract void DisplayInfo();
}
