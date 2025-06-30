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
                Console.WriteLine($"{Name} has eaten the herbivore");
                if (animal is Herbivore herbivore)
                {
                    herbivore.IsAlive = false;
                    AnimalsEaten++;
                }
            }
            else
            {
                Console.WriteLine($"{Name} couldn't eat the herbivore.");
            }
        }
    }
}
