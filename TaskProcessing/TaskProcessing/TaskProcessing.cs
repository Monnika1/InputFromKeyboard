namespace TaskProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Queue<string> tasks = new Queue<string>();  
            tasks.Enqueue("Print report");
            tasks.Enqueue("Send email");
            tasks.Enqueue("Backup files");
            tasks.Enqueue("Update database");

            while (tasks.Count > 0)
            {
                string currentTask = tasks.Dequeue();
                Console.WriteLine($"Processing task: {currentTask}");

                Console.WriteLine($"Remaining task: {tasks.Count}");
            }

        }
    }
}
