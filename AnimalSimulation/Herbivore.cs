namespace AnimalSimulation
{
    public class Herbivore : Animal
    {
        public Herbivore(string name, Position currentPosition, int gender) : base(name,currentPosition, gender)
        {
        }

        public override bool CanEat()
        {
            return false;
        }

        public override void Eat(Animal animal)
        {
        }
    }
}