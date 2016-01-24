using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    using Interface;
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private Gender gender;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Age cannot be negative");
                }
                this.age = value;
            }
        }
        private Gender Gender {
            get { return this.gender;}
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Gender cannot be empty");
                }
            }
        }

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name: {0}\nAge: {1}\nGender: {2}\nSound: {3}",this.Name,this.Age,this.Gender,this.ProduceSound());
            return sb.ToString();
        }
    }
}
