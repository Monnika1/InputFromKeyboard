namespace AnimalSimulation
{
    public class Herbivore : Animal
    {
        public Herbivore(string name, Position currentPosition) : base(name,currentPosition)
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