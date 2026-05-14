namespace Day2
{
    class EvenOrOddRangeGenerator
    {
        static void Main(string[] args)
        {
            int range =50;

            for(int i = 0; i <= range; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" is even");
                }
                else
                {
                    Console.WriteLine(i+" is odd");
                }
            }
        }


    }
}