using System;
using Interface;

namespace AbstractClasses
{
    abstract class Worker // implementation
    {
        public abstract void Work();
        public abstract int GetSalary();

        public virtual void PrintName()
        {
            Console.WriteLine("Hello Worker");
        }

    }

    class Teacher : Worker
    {
        public override void Work()
        {
            Console.WriteLine("Teaching");
        }

        public override int GetSalary()
        {
            return 100;
        }

        public override void PrintName()
        {
            Console.WriteLine("Hello Teacher");
        }
    }

    class Developer : Worker
    {
        public override void Work()
        {
            Console.WriteLine("Coding");
        }

        public override int GetSalary()
        {
            return 10000;
        }

        public virtual void Get()
        {

        }
        public override void PrintName()
        {
            Console.WriteLine("Hello Medine");
            base.PrintName();
        }
    }

    class User
    {
        public User(string name,int id,string surname,string password)
        {
            Name = name;
            Id = id;
            Surname = surname;
            Password = password;
        }
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }


    }
    class Program
    {

        static void Main(string[] args)
        {

            /*Worker teacher = new Teacher();
            teacher.Work();
            teacher.PrintName();
            Console.WriteLine(teacher.GetSalary());
            Worker developer = new Developer();
            developer.Work();
            developer.PrintName();
            Console.WriteLine(developer.GetSalary());*/


            User user = new User("Medine",1,"Elizade","abc123");
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Surname);
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Id);

            Person person = new Person();
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
            Console.WriteLine(manager.GetFullName());



        }
    }
}
