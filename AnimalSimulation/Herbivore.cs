using AnimalSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    internal class Herbivore : IAnimal
    {
        public string Name { get ; set ; }
        public int Position { get ; set ; }

        public bool IsAlive { get; set; }

        public Herbivore(string name, int position)
        {
            Name = name;
            Position = position;
            IsAlive = true; 
        }
    }
}
