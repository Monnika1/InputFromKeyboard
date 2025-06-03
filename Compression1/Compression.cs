using System.Text;

namespace Compression1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine(Compress("aaaaabbcd"));  
                Console.WriteLine(Compress("abc"));        
                Console.WriteLine(Compress("AAbbAA"));     
                Console.WriteLine(Compress(""));           

                Console.WriteLine(Decompress("a5b2c1d1")); 
                Console.WriteLine(Decompress("A2b2A2"));   
            }

            static string Compress(string input)
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

            static string Decompress(string input)
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
