using static Zoo.Program;

namespace Zoo
{
    internal class Parrot:IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Parrot(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string MakeSound()
        {
            return "Squawk";
        }
    }
}
