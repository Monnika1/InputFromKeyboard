namespace FileExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Moni\OneDrive\Desktop\Shop\InputFromKeyboard";
            ReadFilesAndDirectories(rootPath);
            Console.ReadLine();

        }
        static void ReadFilesAndDirectories(string path)
        {
            try
            {
                Console.WriteLine("Directory: " + path);
                var files = Directory.GetFiles(path);
                Console.WriteLine("Files:");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                var directories = Directory.GetDirectories(path);

                foreach (var dir in directories)
                {
                    ReadFilesAndDirectories(dir);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
