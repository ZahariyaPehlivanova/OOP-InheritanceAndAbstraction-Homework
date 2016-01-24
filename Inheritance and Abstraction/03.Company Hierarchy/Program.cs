using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager("12191311", "Yordan", "Todorov", 4000m, "Sales",
           new List<Employee> {
                { new Employee("12191311", "Stoyan", "Dimov", 2000m, "Sales")},
                { new Employee("1219131", "Dimitur", "Petrov", 1700m, "Sales")},
                { new Employee("12191311", "Mariq", "Ivanova", 2300m, "Sales")},
           });

            Manager managerSecond = new Manager("19112311", "Ivan", "Ivanov", 3500, "Marketing",
           new List<Employee> {
                { new Employee("12191311", "Gosho", "Goshov", 1200m, "Marketing")},
                { new Employee("1219131", "Dragan", "Draganov", 2700m, "Marketing")},
                { new Employee("12191311", "Pesho", "Peshov", 1000m, "Marketing")},
           });
            SalesEmployee salesEmployee = new SalesEmployee("78873465", "Ivan", "Marinov", 8800m, "Production",
             new List<Sale> {
                { new Sale("12345678", DateTime.Parse("01.4.13"), 2700)},
                { new Sale("98765432", DateTime.Parse("21.8.15"), 20000)},
                { new Sale("35715964", DateTime.Parse("17.3.14"), 3500)},
                { new Sale("75915346", DateTime.Parse("22.12.12"), 3400)}
             });

            Developer developer = new Developer("11111111", "Mira", "Dimitrova", 5000m, "Accounting",
               new List<Project> {
                { new Project("Money", DateTime.Parse("12.9.2011"), "The project makes money")},
                { new Project("Moneyyyyy", DateTime.Parse("21.11.2015"), "The project makes money,too")}
               });
            List<Employee> list = new List<Employee>() {manager,managerSecond,salesEmployee,developer};

            foreach (var l in list)
            {
                Console.WriteLine(l);
                Console.WriteLine();
            }
        }
    }
}
