using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation.Interfaces
{
    internal interface IAnimal
    {
        string Name { get; set; }
        int Position { get; set; }

    }
}
