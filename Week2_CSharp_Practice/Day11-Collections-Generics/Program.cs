using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ArrayList data = new ArrayList();

        data.Add(100);
        data.Add("Balaji");

        Console.WriteLine("ArrayList Data:");

        foreach (var item in data)
        {
            Console.WriteLine(item);
        }

        List<string> names = new List<string>();

        names.Add("Balaji");
        names.Add("Rahul");
        names.Add("Kiran");

        Console.WriteLine("\nList Data:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Balaji");
        students.Add(102, "Rahul");

        Console.WriteLine("\nDictionary Data:");

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} - {student.Value}");
        }

        Queue<string> tickets = new Queue<string>();

        tickets.Enqueue("Person1");
        tickets.Enqueue("Person2");

        Console.WriteLine("\nQueue Output:");
        Console.WriteLine(tickets.Dequeue());

        Stack<int> numbers = new Stack<int>();

        numbers.Push(10);
        numbers.Push(20);
        numbers.Push(30);

        Console.WriteLine("\nStack Output:");
        Console.WriteLine(numbers.Pop());
    }
}
