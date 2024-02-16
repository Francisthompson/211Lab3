using System;

abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter dog's name:");
        string dogName = Console.ReadLine();
        Dog dog = new Dog();
        dog.Name = dogName;
        dog.Colour = "Brown";
        dog.Age = 5;

        Console.WriteLine("Dog Properties:");
        Console.WriteLine("Name: " + dog.Name);
        Console.WriteLine("Colour: " + dog.Colour);
        Console.WriteLine("Age: " + dog.Age);
        dog.Eat();

        Console.WriteLine("\nEnter cat's name:");
        string catName = Console.ReadLine();
        Cat cat = new Cat();
        cat.Name = catName;
        cat.Colour = "White";
        cat.Age = 3;

        Console.WriteLine("\nCat Properties:");
        Console.WriteLine("Name: " + cat.Name);
        Console.WriteLine("Colour: " + cat.Colour);
        Console.WriteLine("Age: " + cat.Age);
        cat.Eat();
    }
}
