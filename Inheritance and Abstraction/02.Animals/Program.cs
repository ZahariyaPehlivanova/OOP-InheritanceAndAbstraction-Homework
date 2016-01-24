using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Animals
{
    class Program
    {
        static void Main()
        {

            Kitten Lili = new Kitten("Lili",2);
            Dog Sharo = new Dog("Sharo", 4, Gender.Male);
            Frog Frog = new Frog("Frog", 5, Gender.Female);
            Cat Jerry = new Cat("Jerry",7,Gender.Male);
            Tomcat Tom = new Tomcat("Tom", 3);
            Dog Pyhcho = new Dog("Pyhcho", 1, Gender.Male);
            List<Animal> animals = new List<Animal>() { Lili, Sharo, Frog, Tom,Pyhcho,Jerry };

            foreach (var animal in animals)
            {
                Console.WriteLine("{0}\n", animal);
            }

            animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .ToList()
                .ForEach(group => Console.WriteLine("{0} average age : {1}",group.AnimalName,group.AverageAge));
        }
    }
}
