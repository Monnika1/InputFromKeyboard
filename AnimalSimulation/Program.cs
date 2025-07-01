namespace AnimalSimulation
{
    internal class Program
    {
        private static Timer _timer;
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Simulation Started");
            World world = new World(4, 4, 1000);
            List<Animal> animals = new List<Animal>
            {
                new Carnivore("Lion", new Position(0, 0), 1),
                new Herbivore("Deer", new Position(1, 1), 0),
                new Carnivore("Tiger", new Position(2, 2), 1),
                new Herbivore("Rabbit", new Position(3, 3), 0),
                new Herbivore("Rabbit", new Position(0, 0), 0)
            };
            _timer = new Timer((e) =>
            {
                world.DoTheSimulation(animals);
                if (!world.AreThereAnyAliveHerbivores(animals))
                {
                    Console.WriteLine("All herbivores are dead. Simulation ending.");
                    _timer.Dispose();
                    return;
                }
            }, null, 0, world.TimeInMiliseconds);
            Console.WriteLine("Press any key to exit...");

            Console.ReadLine();
        }
    }
}