using System;

interface IPayment
{
    void Pay(double amount);
}

abstract class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public abstract void Work();

    public virtual void Login()
    {
        Console.WriteLine("Employee logged in");
    }
}

class Developer : Employee, IPayment
{
    public Developer(string name) : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is writing backend APIs");
    }

    public override void Login()
    {
        Console.WriteLine($"{Name} logged into Visual Studio");
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Salary credited: {amount}");
    }
}

class Program
{
    static void Main()
    {
        Developer dev = new Developer("Balaji");

        dev.Login();
        dev.Work();
        dev.Pay(25000);
    }
}
