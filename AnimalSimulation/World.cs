using AnimalSimulation;

namespace AnimalSimulation
{
    internal class World
    {
        public Position StartOfWorld { get; set; }

        public Position EdgeOfTheWorld { get; set; }

        public int TimeInMiliseconds { get; set; }

        public List<Cell> Cells { get; set; }

        public PositionVaidator Validator { get; set; }

        public World(int x, int y, int miliseconds)
        {
            TimeInMiliseconds = miliseconds;
            Cells = PopulateWorld(x, y);
            StartOfWorld = new Position(0, 0);
            EdgeOfTheWorld = new Position(x - 1, y - 1);
            Validator = new PositionVaidator(StartOfWorld, EdgeOfTheWorld);
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
                int random = rnd1.Next(1, 4);
                if (random == 1)
                    continue;

                else if (random == 2)
                {
                    cell.Animals.Add(new Carnivore("Carnivore", cell.Coordinates));
                }

                else if (random == 3)
                {
                    cell.Animals.Add(new Herbivore("Herbivore", cell.Coordinates));
                }
            }
            return list;

        }
        public void DoTheSimulation()
        {
            foreach (var animal in Cells.SelectMany(x => x.Animals).ToList())
            {
                ChangePositions(animal);
            }

            foreach (var cell in Cells)
            {
                IncreaseAge(cell);
            }

            PrintAnimalPositions();
        }

        public bool AreThereAnyAliveHerbivores()
        {
            return Cells.SelectMany(x => x.Animals).OfType<Herbivore>().Any(h => h.IsAlive);
        }
        private void IncreaseAge(Cell cell)
        {
            foreach (var animal in cell.Animals)
            {
                animal.Grow();
            }
        }
        private void ChangePositions(Animal current)
        {
            Cell cell = Cells.Where(x => x.Coordinates.Equals(current.CurrentPosition)).SingleOrDefault();
            if (cell is null)
                return;

            Position newPosition = current.Move();
            if (Validator.IsValidPosition(newPosition) && newPosition != current.CurrentPosition)
            {
                Cell newCell = Cells.Where(x => x.Coordinates.Equals(newPosition)).FirstOrDefault();
                if (newCell is not null)
                {
                    cell.Leave(current);
                    newCell.Visit(current);
                    current.CurrentPosition = newPosition;

                    foreach (var another in newCell.Animals.ToList().Except([current]))
                    {
                        Animal newAnimal = current.Mate(another);
                        if (newAnimal is not null)
                            newCell.Visit(current);
                    }
                }
            }

        }
        private async void PrintAnimalPositions()
        {
            Console.Clear();

            for (int y = StartOfWorld.Y; y <= EdgeOfTheWorld.Y; y++)
            {
                for (int x = StartOfWorld.X; x <= EdgeOfTheWorld.X; x++)
                {
                    Cell currentCell = Cells.Where(cell => cell.Coordinates.X.Equals(x) && cell.Coordinates.Y.Equals(y)).SingleOrDefault();
                    if (currentCell == null || currentCell.Animals.Count == 0)
                    {
                        Console.Write("[   ]");
                        continue;
                    }
                    Animal animal = currentCell.Animals.First();

                    if (animal.Age >= 5 && animal is Carnivore)
                    {
                        Console.Write("[ C ]");
                    }
                    else if (animal.Age >= 5 && animal is Herbivore)
                    {
                        Console.Write("[ H ]");
                    }
                    else if (animal.Age < 5 && animal is Carnivore)
                    {
                        Console.Write("[ c ]");
                    }
                    else if (animal.Age < 5 && animal is Herbivore)
                    {
                        Console.Write("[ h ]");
                    }
                }
                Console.WriteLine();
            }
            await Task.Delay(TimeInMiliseconds);
            Console.Write(Environment.NewLine);
        }
    }
}

