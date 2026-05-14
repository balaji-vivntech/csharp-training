using System;

namespace Day2
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {   

            int range = 100;

            for(int i = 1; i <= range; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}