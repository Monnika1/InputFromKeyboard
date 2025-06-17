using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zoo.Program;

namespace Zoo
{
    internal class Elephant : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Elephant(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string MakeSound()
        {
            return "Auuu";
        }
    }
}

