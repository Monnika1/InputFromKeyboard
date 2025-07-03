namespace AnimalSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Simulation Started");

            World world = new World(5, 5, 1000);

            bool shouldEndTheSimulation = false;

            while (shouldEndTheSimulation == false)
            {
                world.DoTheSimulation();
                if (world.AreThereAnyAliveHerbivores() == false)
                {
                    Console.WriteLine("All herbivores are dead. Simulation ending.");
                    shouldEndTheSimulation = true;
                }

                Task.Delay(world.TimeInMiliseconds).GetAwaiter().GetResult();
            }
           Console.ReadLine();
        }
    }
}