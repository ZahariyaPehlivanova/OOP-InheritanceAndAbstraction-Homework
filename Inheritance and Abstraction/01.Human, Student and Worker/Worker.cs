using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
    class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName)
           : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay) : this(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;

        }
        public int WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Week salary cannot be zero");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be in range [0]..[24]");
                }
                this.workHoursPerDay = value;
            }
        }


        public decimal MoneyPerHour(int daysPerWeek)
        {
            return this.WeekSalary / (decimal)(daysPerWeek * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Week salary: {0}\nWork hours per day: {1}\nMoney per hour: {2:F2}", this.WeekSalary, this.WorkHoursPerDay,this.MoneyPerHour(5));
        }
    }
}
