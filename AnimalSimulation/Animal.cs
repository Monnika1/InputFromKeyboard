namespace AnimalSimulation
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Position CurrentPosition { get; set; }
        public bool IsAlive { get; set; }
        public Animal(string name, Position position)
        {
            Name = name;
            CurrentPosition = position;
            IsAlive = true;
        }
        public Position Move()
        {
            // random 1-4
            // 1 = up, 2 = down, 3 = left, 4 = right
            Random random = new Random();
            int direction = random.Next(1, 4);
            switch (direction)
            {
                case 1:
              return CurrentPosition.MoveByY(1);
                case 2:
                     return CurrentPosition.MoveByY(-1);
                case 3:
                    return CurrentPosition.MoveByX(-1);
                case 4:
                    return CurrentPosition.MoveByX(1);
                default:
                    throw new InvalidOperationException("Invalid direction");
            }
        }
        public abstract bool CanEat();

        public abstract void Eat(Animal animal);
    }
}