using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
    class Program
    {
        static void Main(string[] args)
        {

            Student Mariq = new Student("Mariq", "Ivanova", "1AS53486");
            Student Ivan = new Student("Ivan", "Draganov", "8TR45152");
            Student Gosho = new Student("Gosho", "Goshov", "5ASFTHD6");
            Student Iva = new Student("Iva", "Ivova", "6A562G87");
            Student Pesho = new Student("Pesho", "Peshov", "7GD89654");
            Student Mariika = new Student("Mariika", "Goshova", "8S53ASBT");
            Student Miro = new Student("Miro", "Mirov", "1A3456OP");
            Student Nikoleta = new Student("Nikoleta", "Dimitrova", "7WSCA453");
            Student Tedo = new Student("Tedo", "Ivanov", "1MN69875");
            Student Stefan = new Student("Stefan", "Chyshkov", "6S2XSDHE");

            List<Student> students = new List<Student>() { Mariq, Ivan, Gosho, Iva, Pesho, Mariika, Miro, Nikoleta, Tedo, Stefan };

            Worker Mira = new Worker("Mira", "Ivanova", 400, 10);
            Worker Ivo = new Worker("Ivo", "Ivov", 100, 3);
            Worker Dragan = new Worker("Dragan", "Peshov", 300, 9);
            Worker Nina = new Worker("Nina", "Georgieva", 900, 11);
            Worker Kolio = new Worker("Kolio", "Peshev", 500, 9);
            Worker Mimi = new Worker("Mimi", "Koleva", 360, 7);
            Worker Misho = new Worker("Misho", "Ivanov", 470, 3);
            Worker Nikola = new Worker("Nikola", "Deshev", 1800, 8);
            Worker Geri = new Worker("Geri", "Ivanova", 2000, 7);
            Worker Lili = new Worker("Lili", "Dobreva", 3000, 12);

            List<Worker> workers = new List<Worker>() { Mira, Ivo, Dragan, Nina, Kolio, Mimi, Misho, Nikola, Geri, Lili };

            Console.WriteLine("Sorted students:");
            Console.WriteLine();

            var studentsList = (from t in students
                                select t).OrderBy(c => c.FacultyNumber);

            foreach (var student in studentsList)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sorted workers:");
            Console.WriteLine();
            var workersList = (from t in workers
                               select t).OrderByDescending(x => x.MoneyPerHour(5));
            foreach (var worker in workersList)
            {
                Console.WriteLine(worker);
                Console.WriteLine();
            }
             List<Human> merged = new List<Human>();
             merged.AddRange(students);
             merged.AddRange(workers);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ordered by names:");
            Console.WriteLine();
            foreach (var human in merged.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}