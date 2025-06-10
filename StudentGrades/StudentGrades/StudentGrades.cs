namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<(string Name, string Grade)> students = new List<(string, string)>
            {
                ("Alice", "A"),
                ("Bob", "B"),
                ("Kiril", "A"),\S
                ("Max", "C")
            };
            var groupedStudents = students
                 .GroupBy(s => s.Grade).ToDictionary(g => g.Key, g => g.Select(s => s.Name).ToList());

            foreach (var pair in groupedStudents)
            {
                Console.WriteLine($"{pair.Key}-{string.Join(", ", pair.Value)}");

            }


        }
    }

}