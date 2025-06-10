namespace UniqueIDs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> userIDs = new HashSet<int> {101,202,303,101,404,505,303 };
            Console.WriteLine("Unique IDs:");
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
            Console.WriteLine($"\nCount after removal:{userIDs.Count}");
            
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
