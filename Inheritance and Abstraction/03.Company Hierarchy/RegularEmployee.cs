using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    using Interfaces;

    class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, string department) 
            : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
