using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    using Interfaces;
    public class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public string Id
        {
            get { return this.id;}
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Id cannot be null");
                }
                this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null");
                }
                this.lastName = value;
            }
        }

        public Person(string id,string firstName,string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}\nFirst name: {1}\nLast name: {2}\n",this.Id,this.FirstName,this.LastName);
            return sb.ToString();
        }
    }
}
