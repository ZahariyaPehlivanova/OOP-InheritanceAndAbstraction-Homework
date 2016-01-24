using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public  class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
        : base(name,age,gender)
        {
        }
        public override string ProduceSound() => "Crqk!";
    }
}
