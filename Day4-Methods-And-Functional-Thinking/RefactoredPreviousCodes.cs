namespace Day4
{
    class RefactoredPreviousCodes
    {
         public void FizzBuzz(int range)
        {
            
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


// using switch case here for applying what i learnt
        public static void GenerateEvenOrOdd(int range)
        {
            for(int i = 0; i <= range; i++)
            {
                switch(i % 2)
                {
                    case 1:
                    Console.WriteLine($"{i} is even");
                    break;

                    case 2:
                    Console.WriteLine($"{i} is odd");
                    break;
                }
            }
        }
    }
}