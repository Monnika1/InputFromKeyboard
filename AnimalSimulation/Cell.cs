namespace AnimalSimulation
{
    internal class Cell
    {
        public Position Coordinates { get; set; }
    
        public List<Animal> Animals { get; set; }

        public Cell(Position coordinates)
        {
            Coordinates = coordinates;
            Animals = new List<Animal>();
        }

        public void Visit(Animal animal)
        {
            Animals.Add(animal);

            foreach (var current in Animals.ToList())
            {
                if (animal.CanEat()) 
                {
                    animal.Eat(current);
                }

                if(current.IsAlive == false)
                {
                    Leave(current);
                }
            }
        }
        public void Leave(Animal animal)
        {
            Animals.Remove(animal);
        }
    }
}