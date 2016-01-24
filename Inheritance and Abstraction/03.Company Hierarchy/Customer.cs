using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    using Interfaces;
   
        class Customer : Person//, ICustomer
        {
            private decimal spentMoney;
            public Customer(string id, string firstName, string lastName, decimal totalAmount) 
            : base(id, firstName, lastName)
            {
                this.SpentMoney = totalAmount;
            }

            public decimal SpentMoney
        {
                get { return this.spentMoney; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Amount cannot be negative.");
                    }

                    this.spentMoney = value;
                }
            }

            public override string ToString()
            {
                StringBuilder print = new StringBuilder();
                print.AppendFormat("{0} {1} Id: {2} \n\r", this.FirstName, this.LastName, this.Id);
                print.AppendFormat("Total Amount: {0}", this.SpentMoney);
                return print.ToString();
            }
        }
}
