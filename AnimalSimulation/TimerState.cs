using AnimalSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    internal class TimerState
    {
        public World World { get; set; }
        public List<IAnimal> Animals { get; set; }
    }
}
