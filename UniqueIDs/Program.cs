namespace UniqueIDs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> userIDs = new HashSet<int> {101,202,303,101,404,505,303 };
            bool addResult = userIDs.Add(101);
            if(addResult == false)
                Console.WriteLine("ne stava");
            Console.WriteLine("Unique IDs:");
            userIDs.Any(x => x > 100); // This line is not necessary, but shows how to use Any
            foreach (var id in userIDs)
            {
                Console.WriteLine(id);
            }
            if (userIDs.Contains(202))
            {
                Console.WriteLine("\nID 202 exists in the set.");
            }
            else
            {
                Console.WriteLine("\nID 202 does not exist in the set.");
            }
            userIDs.Remove(404);
            Console.WriteLine($"Count after removal:{userIDs.Count}");
            
            HashSet<int> otherIDs = new HashSet<int> { 303, 505, 606, 707 };

            var intersection = userIDs.Intersect(otherIDs);
            Console.WriteLine("\nIntersection with other IDs:");
            foreach (var id in intersection)
            {
                Console.WriteLine(id);
            }
            var union = userIDs.Union(otherIDs);
            Console.WriteLine("\nUnion with other IDs:");
            foreach (var id in union)
            {
                Console.WriteLine(id);
            }

            var difference = userIDs.Except(otherIDs);
            Console.WriteLine("\nDifference with other IDs:");
            foreach (var id in difference)
            {
                Console.WriteLine(id);
            }
                    }
    }
}
