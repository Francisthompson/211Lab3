using System;
using System.Collections.Generic;

interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    int Height { get; set; }
    int Age { get; set; }

    void Eat();
    string Cry();
}

class Dog : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

class Cat : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public string Cry()
    {
        return "Meow!";
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
        dog.Height = 30;
        dog.Age = 5;

        Console.WriteLine("Dog Properties:");
        Console.WriteLine("Name: " + dog.Name);
        Console.WriteLine("Colour: " + dog.Colour);
        Console.WriteLine("Height: " + dog.Height + " cm");
        Console.WriteLine("Age: " + dog.Age);
        dog.Eat();
        Console.WriteLine("Dog says: " + dog.Cry());

        Console.WriteLine("\nEnter cat's name:");
        string catName = Console.ReadLine();
        Cat cat = new Cat();
        cat.Name = catName;
        cat.Colour = "White";
        cat.Height = 25;
        cat.Age = 3;

        Console.WriteLine("\nCat Properties:");
        Console.WriteLine("Name: " + cat.Name);
        Console.WriteLine("Colour: " + cat.Colour);
        Console.WriteLine("Height: " + cat.Height + " cm");
        Console.WriteLine("Age: " + cat.Age);
        cat.Eat();
        Console.WriteLine("Cat says: " + cat.Cry());

        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(dog);
        animals.Add(cat);

        Console.WriteLine("\nNames of all animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}
