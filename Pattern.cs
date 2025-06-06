namespace PatternDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

            Console.WriteLine("Second:");
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j<5-i; j++)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m <=i; m++)
                {
                     Console.Write("*");   
                }
                Console.WriteLine();
            }

        }
    }
}