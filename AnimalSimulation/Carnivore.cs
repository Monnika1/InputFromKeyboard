namespace AnimalSimulation
{
    public class Carnivore : Animal
    {
        public int AnimalsEaten { get; set; }

        public Carnivore(string name, Position current) : base(name, current)
        {
            AnimalsEaten = 0;
        }

        public override bool CanEat()
        {
            return true;
        }

        public override void Eat(Animal animal)
        {
            AttackModifier attackModifier = new AttackModifier();

            if (attackModifier.WillDie())
            {
                if (animal is Herbivore herbivore)
                {
                    herbivore.IsAlive = false;
                    AnimalsEaten++;
                }
            }
            else
            {
                if (animal is Carnivore carnivore)
                {
                    carnivore.IsAlive = true;
                }
            }
        }
        public override Animal Mate(Animal anotherAnimal)
        {
            if (anotherAnimal is Carnivore)
            {
                bool areDifferentGender = Gender != anotherAnimal.Gender;
                bool areOldENough = Age >= 5 && anotherAnimal.Age >= 5;
                if (areDifferentGender && areOldENough)
                {
                    return new Carnivore("Carnivore", CurrentPosition);
                }
            }
            return null;
        }
    }
}
