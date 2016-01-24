﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    using Interfaces;
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(string id, string firstName, string lastName, decimal salary, string department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} {1} Id: {2} \n\rSalary: {3}\n\rDepartment: {4}\n\rSales:n\r", this.FirstName, this.LastName, this.Id, this.Salary, this.Department);
            foreach (var project in this.Sales)
            {
                print.AppendLine(project.ToString());
            }

            return print.ToString();
        }
    }
}