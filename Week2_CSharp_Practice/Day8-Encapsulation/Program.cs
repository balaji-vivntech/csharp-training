using System;

class Student
{
    private string _name;

    public int Id { get; set; }

    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _name = value;
            }
        }
    }

    public string College { get; private set; }

    public static string Course;

    static Student()
    {
        Course = "MCA";
        Console.WriteLine("Static constructor executed");
    }

    public Student(int id, string name, string college)
    {
        Id = id;
        Name = name;
        College = college;
    }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"College: {College}");
        Console.WriteLine($"Course: {Course}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "Balaji", "MIC College");
        s1.Display();
    }
}
