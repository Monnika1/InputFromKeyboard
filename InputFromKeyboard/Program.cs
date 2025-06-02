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
        // qwerty
        static string ReverseText(string input)
        {
            string result = string.Empty;
            for (int i = input.Length-1; i >=0; i--)
            {
                    result += input[i];
            }
            return result;
        }
    }
}
