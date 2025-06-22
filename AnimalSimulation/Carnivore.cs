using AnimalSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    internal class Carnivore : IAnimal
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int AnimalsEaten { get; set; }

        public Carnivore(string name, int position)
        {
            Name = name;
            Position = position;
            AnimalsEaten = 0;
        }
    }

}
