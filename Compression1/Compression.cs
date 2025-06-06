using System.Text;

namespace Compression1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine(Compressed("aaaaabbcd"));  
                Console.WriteLine(Compressed("abc"));        
                Console.WriteLine(Compressed("AAbbAA"));     
                Console.WriteLine(Compressed(""));           

                Console.WriteLine(Decompressed("a5b2c1d1")); 
                Console.WriteLine(Decompressed("A2b2A2"));   
            }

            static string Compressed(string input)
            {
                if (string.IsNullOrEmpty(input)) return input;

                StringBuilder compressed = new StringBuilder();
                int count = 1;

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == input[i - 1])
                        count++;
                    else
                    {
                        compressed.Append(input[i - 1]).Append(count);
                        count = 1;
                    }
                }
                compressed.Append(input[^1]).Append(count);

                return compressed.Length < input.Length ? compressed.ToString() : input;
            }

            static string Decompressed(string input)
            {
                if (string.IsNullOrEmpty(input)) return input;

                StringBuilder decompressed = new StringBuilder();
                for (int i = 0; i < input.Length;)
                {
                    char character = input[i++];
                    string countStr = "";

                    while (i < input.Length && char.IsDigit(input[i]))
                        countStr += input[i++];

                    int count = int.Parse(countStr);
                    decompressed.Append(character, count);
                }

                return decompressed.ToString();
            }
        

    }
}
