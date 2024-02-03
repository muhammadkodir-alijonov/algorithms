using System;

// Base class
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine("Generic animal sound.");
    }
}

// Derived class
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public new void MakeSound() // Hiding the base class method with "new" keyword
    {
        Console.WriteLine("Dog barks.");
    }
}

public class Program
{
    public static void Main()
    {
        Dog dog = new Dog("Buddy");
        Console.WriteLine($"Dog's name: {dog.Name}");

        dog.MakeSound(); // Calls the derived class method
        dog.Bark(); // Calls the method specific to the Dog class

        Animal animalDog = dog; // Assigning a Dog object to an Animal reference
        animalDog.MakeSound(); // Calls the base class method since it's not overridden in the derived class
    }
}
