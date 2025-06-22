using AnimalSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    internal class World
    {
        public void ChangePositions(IEnumerable<IAnimal> animals)
        {
            Random rnd = new Random();
            foreach (var animal in animals)
            {
                int position = rnd.Next(1, 6);
                animal.Position = position;
            }
         
        }

        public void CheckForCollisions(IEnumerable<IAnimal> animals)
        {
            var herbivores = animals.OfType<Herbivore>().ToList();
            var carnivores = animals.OfType<Carnivore>().ToList();
             Random rnd = new Random();

            foreach (var carnivore in carnivores)
            {
                foreach (var herbivore in herbivores)
                {
                    if (carnivore.Position == herbivore.Position && herbivore.IsAlive && rnd.NextDouble()<0.6)
                    {
                        carnivore.AnimalsEaten++;
                        herbivore.IsAlive = false;
                        Console.WriteLine($"{carnivore.Name} has eaten {herbivore.Name} at position {herbivore.Position}.");
                    }
                }
            }
        }
    }
}
