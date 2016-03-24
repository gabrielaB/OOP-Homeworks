using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    class HumanStudentWorkerMain
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Georgi","Ivanov","556gi"),
                new Student("Ivan","Ivanov","55556ii"),
                new Student("Stoyan","Georgiev","rfsti6"),
                new Student("Ivan","Ivanov","6gi543453"),
                new Student("Iliqn","Georgiev","5sfdi3"),
                new Student("Kalin","Petrov","gi3333"),
                new Student("Petar","Stoyanos","ddg1125"),
                new Student("Stoicho","Ivanov","55kk6gi"),
                new Student("Georgi","Petrov","5553gi"),
                new Student("Ivan","Dimov","h56gi")
            };

            students = students.OrderBy(s => s.FacultyNumber).ToList();
            List<Human> humans= new List<Human>();
            foreach (var student in students)
            {
                Console.WriteLine(student);
                humans.Add(student);
            }

            List<Worker> workers = new List<Worker>()
            {
                 new Worker("Georgi","Ivanov",200,5),
                new Worker("Ivan","Ivanov",250,5),
                new Worker("Stoyan","Georgiev",150,4),
                new Worker("Ivan","Ivanov",350,8),
                new Worker("Iliqn","Georgiev",400,10),
                new Worker("Kalin","Petrov",380,9),
                new Worker("Petar","Stoyanos",500,12),
                new Worker("Stoicho","Ivanov",100,2),
                new Worker("Georgi","Petrov",700,15),
                new Worker("Ivan","Dimov",450,10)
            };
            workers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();
            Console.WriteLine();
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
                humans.Add(worker);

            }
            Console.WriteLine();
            humans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }


        }
    }
}
