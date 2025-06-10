namespace NumberFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1, 3, 2, 1, 4, 3, 2, 1 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict[number] = 1;
                }
            }   
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Number: {kvp.Key}, Frequency: {kvp.Value}");
            }
        }
    }
}
