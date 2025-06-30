namespace AnimalSimulation
{
    internal class World
    {
        public Position StartOfWorld { get; set; }

        public Position EdgeOfTheWorld { get; set; }

        public int TimeInMiliseconds { get; set; }

        public List<Cell> Cells { get; set; }

        public World(int x, int y, int miliseconds)
        {
            TimeInMiliseconds = miliseconds;
            Cells = PopulateWorld(x, y);
            StartOfWorld = new Position(0, 0);
            EdgeOfTheWorld = new Position(x - 1, y - 1);
        }

        private List<Cell> PopulateWorld(int x, int y)
        {
            var list = new List<Cell>();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var cell = new Cell(new Position(i, j));
                    list.Add(cell);
                }
            }

            Random rnd1 = new Random();

            foreach (Cell cell in list)
            {
                int random = rnd1.Next(1, 3);

                if (random == 1)
                    continue;

                else if(random == 2)
                    cell.Animals.Add(new Carnivore("Carnivore", cell.Coordinates));

                else if (random == 3)
                    cell.Animals.Add(new Herbivore("Herbivore", cell.Coordinates));
            }

            return list;
        }

        public void DoTheSimulation(IEnumerable<Animal> animals)
        {
            ChangePositions(animals);
            CheckForCollisions(animals);
            PrintAnimalPositions(animals);
        }
        public bool AreThereAnyAliveHerbivores(IEnumerable<Animal> animals)
        {
            return animals.OfType<Herbivore>().Any(h => h.IsAlive);
        }
        private void ChangePositions(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
               animal.CurrentPosition = animal.Move();
            }
        }
        private void CheckForCollisions(IEnumerable<Animal> animals)
        {
            var herbivores = animals.OfType<Herbivore>();
            var carnivores = animals.OfType<Carnivore>();
            Random rnd = new Random();

            foreach (var carnivore in carnivores)
            {
                foreach (var herbivore in herbivores)
                {
                    if (carnivore.CurrentPosition == herbivore.CurrentPosition && herbivore.IsAlive && rnd.NextDouble() < 0.6)
                    {
                        carnivore.AnimalsEaten++;
                        herbivore.IsAlive = false;
                        Console.WriteLine($"{carnivore.Name} has eaten {herbivore.Name} at position {herbivore.CurrentPosition}.");
                    }
                }
            }
        }
        private void PrintAnimalPositions(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Herbivore herbivore)
                {
                    Console.WriteLine($"{herbivore.Name} is at position {herbivore.CurrentPosition}. Alive: {herbivore.IsAlive}");
                }
                else if (animal is Carnivore carnivore)
                {
                    Console.WriteLine($"{carnivore.Name} is at position {carnivore.CurrentPosition}. Animals eaten: {carnivore.AnimalsEaten}");
                }
            }
        }
    }
}