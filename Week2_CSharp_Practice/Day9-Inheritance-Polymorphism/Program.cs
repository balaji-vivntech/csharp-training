using System;

class Animal
{
    protected string Name;

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"Animal is eating {food}");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} says Woof Woof");
    }
}

sealed class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} says Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal a1 = new Dog("Tommy");
        a1.Sound();
        a1.Eat();
        a1.Eat("Chicken");

        Animal a2 = new Cat("Kitty");
        a2.Sound();
    }
}
