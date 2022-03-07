using System;

namespace AccessModifiersInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 20;
            person.FirstName = "Ahmed";
            person.LastName = "Ahmedov";

            Employee employee = new Employee();
            employee.Age = 21;
            employee.FirstName = "Ahmad";
            employee.LastName = "Ahmadov";
            
            Console.WriteLine(employee.GetSalary()) ;
            employee.Work();
            Person m = new Employee
            {
                FirstName = "Medine",
                WorkPlace = "Baku",
                Age = 17,
                LastName = "Elizade"
            };

            MyClass k = new MyClass();
        }
    }
}
