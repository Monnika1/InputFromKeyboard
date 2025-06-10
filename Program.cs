namespace BrowserHistory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> history = new Stack<string>();
            history.Push("home.com");
            history.Push("about.com");
            history.Push("products.com");
            history.Push("contact.com");
            Console.WriteLine("Back button pressed->Went back from: " + history.Pop());
            Console.WriteLine("Back button pressed->Went back from: " + history.Pop());

            history.Push("blog.com");
            Console.WriteLine("Current page: "+history.Peek());

            Console.WriteLine("\nHistory Stack (top to bottoom):");

            foreach (var url in history)
            {
                Console.WriteLine(url);
            }
        }
    }
}
