namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            IAnimal lion = new Lion("Leo", 5);
            zoo.AddAnimal(new Lion("Leo", 5));
            zoo.AddAnimal(new Elephant("Ella", 10));
            zoo.AddAnimal(new Parrot("Polly", 2));
            
            bool doesZooContainLeo = zoo.animals.Contains(lion);

            zoo.MakeAllAnimalsToMakeASound();
            //zoo.GetAnimalAge();
        }
        public interface IAnimal {
            string Name { get; set; }
            int Age { get; set; }
            string MakeSound();
        }
        public class Zoo {
            public List<IAnimal> animals;
            public Zoo()
            {
                animals = new List<IAnimal>();
            }

            public void AddAnimal(IAnimal animal)
            {
                animals.Add(animal);
                Console.WriteLine($"{animal.Name} has been added to the zoo");
            }
            public int GetAnimalAge(string name) {
                IAnimal animal = animals.FirstOrDefault(a => a.Name.Equals(name));
                if (animal != null)
                {
                    return animal.Age;
                }
                else
                {
                    throw new Exception("äaaa");
                }
                
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
