using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zoo.Program;

namespace Zoo
{
    internal class Lion: IAnimal
    {
            public string Name { get; set; }
            public int Age { get; set; }

            public Lion(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string MakeSound()
            {
                return "Roar";
            }
        
    }
}
