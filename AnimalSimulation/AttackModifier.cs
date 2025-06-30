namespace AnimalSimulation
{
    public interface IAttackModifier
    {
        bool WillDie();
    }
    public class AttackModifier : IAttackModifier
    {
        public bool WillDie()
        {
            Random rnd = new Random();
            var randomValue = rnd.NextDouble();
            if (randomValue<=0.6)
            {
                return true;
            }
            return false;
        }
    }
}
