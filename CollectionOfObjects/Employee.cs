namespace CollectionOfObjects
{
    internal class Employee
    {

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
    }

}
