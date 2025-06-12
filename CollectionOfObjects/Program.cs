namespace CollectionOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Kristiyan" , 25 ),
            new Employee ("Peter", 30 ),
            new Employee ("Alice",29 ),
            new Employee ("Bob",35),
            new Employee ("Charlie",50),
            };

            var olderThan30 = employees.Where(e => e.Age > 30);
            Console.WriteLine("Employees older than 30:");
            foreach (var employee in olderThan30)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
            }
            var sortedByName = employees.OrderBy(e => e.Name);
            Console.WriteLine("\nEmployees sorted by name: ");
            //foreach (var employee in sortedByName)
            //{
            //    Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
            //}

            //employees.ForEach(e => Console.WriteLine($"Name: {e.Name}, Age: {e.Age}"));

            Console.WriteLine(string.Join(",",employees.Select(x=> $"Name:{x.Name} Age:{x.Age}")));
            

            double averageAge = employees.Average(e => Convert.ToDouble(e.Age));
            Console.WriteLine($"\nAverage age of employees: {averageAge}");
            IEnumerable<IGrouping<string, Employee>> groupedByAge = employees.GroupBy(e =>
            {
                if (e.Age < 30) return "30";
                else if (e.Age <= 40) return "20-40";
                else return ">40";
                
            });
            Console.WriteLine("\nEmployees grouped by age:");
            foreach (IGrouping<string, Employee> group in groupedByAge)
            {
                Console.WriteLine($"Age Group: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
                }
            }
        }
    }
}
