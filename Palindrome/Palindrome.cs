namespace palindrome
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or a phrase:...");
            string input = Console.ReadLine();
            if (CheckPalindrome(input))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false"); 
            }

        }
        static bool CheckPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            input = input.Replace(" ", "").ToLower();

            return input.SequenceEqual(input.Reverse());
            
        }
    }
}
