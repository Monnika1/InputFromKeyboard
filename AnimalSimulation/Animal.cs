using System;

namespace AnimalSimulation
{
    public enum Gender
    {
        Female = 0,
        Male = 1
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public Position CurrentPosition { get; set; }
        public bool IsAlive { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public Animal(string name, Position position)
        {
            Name = name;
            CurrentPosition = position;
            IsAlive = true;
            Age = 0;
            Gender = GetRandomGender();
        }
        public Position Move()
        {
            // random 1-4
            // 1 = up, 2 = down, 3 = left, 4 = right
            Random random = new Random();
            int direction = random.Next(1, 5);
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

        public abstract Animal Mate(Animal anotherAnimal);

        public void Grow()
        {
            Age++;
        }

        Gender GetRandomGender()
        {
            Random random = new Random();
            int randomGender = random.Next(1, 3);
            if (randomGender == 1)
               return Gender.Female;
            else
                return Gender.Male;
        }
    }
}