namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.AddAnimal(new Lion("Leo", 5));
            zoo.AddAnimal(new Elephant("Ella", 10));
            zoo.AddAnimal(new Parrot("Polly", 2));
            
            zoo.MakeAllAnimalsToMakeASound();
            
        }
        public interface IAnimal {
            string Name { get; set; }
            int Age { get; set; }
            string MakeSound();
        }
        public class Lion: IAnimal{
            public string Name { get; set; }
            public int Age { get; set; }

            public Lion(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string MakeSound()
            {
                return "Roar";
            }
        }
        public class Elephant : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Elephant(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string MakeSound()
            {
                return "Auuu";
            }
        }
        public class  Parrot : IAnimal
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
        public class Zoo {
            private List<IAnimal> animals;
            public Zoo()
            {
                animals = new List<IAnimal>();
            }
            public void AddAnimal(IAnimal animal)
            {
                animals.Add(animal);
                Console.WriteLine($"{animal.Name} has been added to the zoo");
            }

            public void MakeAllAnimalsToMakeASound()
            {
                Console.WriteLine("The animal and his characteristics: ");
                foreach (var animal in animals)
                {
                    Console.WriteLine($"Name:{animal.Name}, Age:{animal.Age}, Sound:{animal.MakeSound()}");
                }
            }
        }
    }
}
