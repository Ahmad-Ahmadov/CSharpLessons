using System;

namespace AccessModifiersInheritance
{
    public class Employee : Person //interface interface
    {
         MyClass m = new MyClass();
        public string WorkPlace { get; set; }
        public void Work()
        {
            
            Console.WriteLine("Working...");
        }
        public int GetSalary()
        {
            salary = 1000;
            return salary;
        }
        
    }
}
