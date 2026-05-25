using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Balaji", Marks = 90 },
            new Student { Id = 2, Name = "Rahul", Marks = 75 },
            new Student { Id = 3, Name = "Kiran", Marks = 85 },
            new Student { Id = 4, Name = "Anil", Marks = 60 }
        };

        var topStudents = students.Where(s => s.Marks > 80);

        Console.WriteLine("Students with marks above 80:");

           foreach (var student in topStudents)
        {
            Console.WriteLine(student.Name);
        }

          var names = students.Select(s => s.Name);

        Console.WriteLine("\nStudent Names:");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        var ordered = students.OrderBy(s => s.Marks);

          Console.WriteLine("\nSorted by Marks:");

        foreach (var student in ordered)
        {
            Console.WriteLine($"{student.Name} - {student.Marks}");
        }

           var first = students.FirstOrDefault(s => s.Marks > 80);

        Console.WriteLine($"\nFirst Topper: {first.Name}");

         var grouped = students.GroupBy(s => s.Marks >= 80 ? "Pass" : "Average");

           Console.WriteLine("\nGrouped Students:");

              foreach (var group in grouped)
        {
            Console.WriteLine(group.Key);

            foreach (var student in group)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
