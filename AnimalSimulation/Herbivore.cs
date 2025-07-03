namespace AnimalSimulation
{
    public class Herbivore : Animal
    {
        public Herbivore(string name, Position currentPosition) : base(name, currentPosition)
        {
        }

        public override bool CanEat()
        {
            return false;
        }

        public override void Eat(Animal animal)
        {
        }

        public override Animal Mate(Animal anotherAnimal)
        {
            if (anotherAnimal is Herbivore)
            {
                bool areDifferentGender = Gender != anotherAnimal.Gender;
                bool areOldENough = Age >= 5 && anotherAnimal.Age >= 5;
                if (areDifferentGender && areOldENough)
                {
                    return new Herbivore("Herbivore", CurrentPosition);
                }
            }
            return null;
        }
    }
}