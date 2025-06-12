namespace Fruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();   
            fruits.Add("Apple");
            fruits.Add("Lime");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Grapes");
            fruits.Add("Kiwi");

            fruits.RemoveAt(2);

            //fruits.Sort();
            var orderedFruits = fruits.OrderBy(x => x).ToList();
            Console.WriteLine("Ascending sort: ");
            foreach (var fruit in orderedFruits)
            {
                Console.WriteLine(fruit);
            }


            var orderedF = fruits.OrderByDescending(x=>x);
            Console.WriteLine("\nDescending sort: ");
            foreach (var fruit in orderedF)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nFruits that start with 'A':");
            var fruitsWithA = fruits.Where(fruit => fruit.StartsWith("A"));
            foreach (var fruit in fruitsWithA)
            {
                Console.WriteLine(fruit);
            }


            int countWithE = fruits.Count(fruit => fruit.Contains("e"));
            Console.WriteLine($"\nCount of fruits containing 'e': {countWithE}");



        }
    }
}
