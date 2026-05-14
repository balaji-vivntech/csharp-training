namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling refactored fizzbuzz here by creating object of it because fizbuz is not a static method
            RefactoredPreviousCodes fizzBuzz = new RefactoredPreviousCodes();
            fizzBuzz.FizzBuzz(10);
            

            // calling new refactored OddOrEven generator using class reference as this is a static method
            RefactoredPreviousCodes.GenerateEvenOrOdd(20);
        
        }

    }
}