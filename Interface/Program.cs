using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface
{
    // SOLID

    interface IWorker
    {
        decimal Salary { get; set; }
    }
    interface IPersonManager
    {
        int GetAge(IPerson m);
        string GetFullName(IPerson m);
        bool IsWorks(IPerson m);
    }
    interface IPerson : IWorker
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        bool IsWorks { get; set; }
        void Sleep(string name);
        string GetFullName();

    }

    class Person : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsWorks { get; set; }

        public void Sleep(string name)
        {
            Console.WriteLine("Sleep");
        }
        public string GetFullName()
        {
            return Name + " " + Surname;
        }

        public decimal Salary { get; set; }
    }

    class Person2 : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsWorks { get; set; }

        public void Sleep(string name)
        {
            Console.WriteLine("Tembel Medine");
        }

        public string GetFullName()
        {
            return Surname + ' ' + Name;
        }

        public decimal Salary { get; set; }
    }

    class Person3 : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsWorks { get; set; }
        public void Sleep(string name)
        {
            throw new NotImplementedException();
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

        public decimal Salary { get; set; }
    }

    class PersonManager : IPersonManager
    {
        public int GetAge(IPerson m)
        {
            return m.Age;
        }

        public string GetFullName(IPerson m)
        {
            return m.Name + " " + m.Surname;
        }

        public bool IsWorks(IPerson m)
        {
            return m.IsWorks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ehmed";
            person.Age = 20;
            person.Surname = "Ehmedov";
            person.IsWorks = true;
            Console.WriteLine(person.GetFullName());

            Person2 p = new Person2();
            p.Name = "Medine";
            p.Surname = "Elizade";
            p.Age = 17;
            p.IsWorks = false;
            Console.WriteLine(p.GetFullName());

            PersonManager manager = new PersonManager();
            Console.WriteLine(manager.IsWorks(new Person3
            {
                Age = 20,
                Surname = "Elizade",
                Name = "Resad",
                IsWorks = true
            }));
            Console.WriteLine(manager.GetAge(new Person3
            {
                Age = 20,
                Surname = "Elizade",
                Name = "Resad",
                IsWorks = true
            }));
            Console.WriteLine(manager.GetFullName(new Person3
            {
                Age = 20,
                Surname = "Elizade",
                Name = "Resad",
                IsWorks = true
            }));

            Console.WriteLine();
            Console.WriteLine(manager.IsWorks(p));
            Console.WriteLine(manager.GetAge(p));
            Console.WriteLine(manager.GetFullName(p));


            /*
             * S O L I D
             *
             * Single Resposibility
             *
             * Open Closed
             *
             * Liskov's Substitution
             *
             * Interface Segregation
             *
             * Dependency Inversion
             */

        }
    }
}
