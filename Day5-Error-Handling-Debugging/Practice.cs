namespace Day5
{
    class Practice{


        public static void PrintArray(int a, int b){

            a=10;
            b=0;

            try{
            int result=a/b;
            Console.WriteLine(result);

            }
            catch(DivideByZeroException )
            {
                Console.WriteLine("exception occured");
            }

            finally
            {
                Console.WriteLine("clean up");
            }

        }
        
    }
}