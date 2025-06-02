namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or a phrase:...");
            string input = Console.ReadLine();
            if (isPalindrome(input))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false"); 
            }

        }
        static bool isPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            input = input.Replace(" ", "").ToLower();

            return input.SequenceEqual(input.Reverse());
            
        }
    }
}
