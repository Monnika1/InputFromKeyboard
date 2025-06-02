using System.Xml;

namespace InputFromKeyboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:...");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                string reversed = ReverseText(input);
                Console.WriteLine($"Output: {reversed}");
            }
        }
        static string ReverseText(string input)
        {
            string result = "" + input[input.Length - 1];
            for (int i = input.Length-2; i >=0; i--)
            {
                if (input[i] != input[i+1])
                {
                    result += input[i];
                }
            }
            return result;
        }
    }
}
