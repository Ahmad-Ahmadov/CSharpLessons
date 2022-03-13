using System;

namespace Interface
{
    // SOLID

    public interface IWorker
    {
        decimal Salary { get; set; }
    }
    /* public interface IPersonManager
     {
         int GetAge();
         string GetFullName();
         bool IsWorks();
     }*/
    public interface IPersonManager
    {
        int GetAge(IPerson m);
        string GetFullName(IPerson m);
        bool IsWorks(IPerson m);
    }
    public interface IPerson : IWorker
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        bool IsWorks { get; set; }
        void Sleep(string name);
        string GetFullName();

    }

    public class Person : IPerson
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

    public class Person2 : IPerson
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

    public class Person3 : IPerson
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

    /*public class PersonManager : IPersonManager
    {
        private readonly IPerson _person;
        public PersonManager(IPerson m)
        {
            _person = m;
        } 
        public int GetAge()
        {
            return _person.Age;
        }

        public string GetFullName()
        {
            return _person.Name + " " + _person.Surname;
        }

        public bool IsWorks()
        {
            return _person.IsWorks;
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            #region Code

            
            
            /*Person person = new Person();
            person.Name = "Ehmed";
            person.Age = 20;
            person.Surname = "Ehmedov";
            person.IsWorks = true;

            Person2 p = new Person2();
            p.Name = "Medine";
            p.Surname = "Elizade";
            p.Age = 17;
            p.IsWorks = false;
            

            PersonManager manager = new PersonManager(p);
            

            Console.WriteLine();
            Console.WriteLine(manager.IsWorks());
            Console.WriteLine(manager.GetAge());
            Console.WriteLine(manager.GetFullName());*/
        #endregion

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
