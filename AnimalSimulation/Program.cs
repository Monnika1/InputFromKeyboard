using AnimalSimulation.Interfaces;

namespace AnimalSimulation
{
    internal class Program
    {
        private static Timer _timer;
        static void Main(string[] args)
        {
            TimerCallback callback= new TimerCallback(ExecuteMethod);
        
            
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Herbivore("Deer", 1));
            animals.Add(new Herbivore("Rabbit", 2));
            animals.Add(new Carnivore("Lion", 3));
            animals.Add(new Carnivore("Tiger", 4));
            World world = new World();
            var state = new TimerState { World = world, Animals = animals };
            _timer = new Timer(callback, state, 0, 2000);
            Console.ReadLine();
        }
        private static void ExecuteMethod(object state)
        {
            if (state is TimerState timerState)
            {
                var herbivores = timerState.Animals.OfType<Herbivore>().ToList();
                var herbivoresLeft = herbivores.Any(a => a.IsAlive);
                if (!herbivoresLeft)
                {
                    Console.WriteLine("All herbivores are gone. Simulation over.");
                    _timer.Dispose(); 
                    Environment.Exit(0); 
                }

                timerState.World.ChangePositions(timerState.Animals);
                timerState.World.CheckForCollisions(timerState.Animals);
            }
            else
            {
                Console.WriteLine("Invalid state passed to the timer callback.");
            }
            
            
        }
    }
}
