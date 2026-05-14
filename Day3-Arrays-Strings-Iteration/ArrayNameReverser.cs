namespace Day3
{
    class ArrayNameReverser
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            Console.WriteLine("Enter 5 names:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNames in reverse order:");

            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{names[i]}");
            }
        }
    }
}