using System;

namespace Classes
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Customer id: {customer.Id}\nCustomer name: " +
                $"{customer.FirstName}\nCustomer's adress: " +
                $"{customer.Address} ");
            Console.WriteLine("Customer added successfully");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated succesfully");
        }
        public void Delete()
        {
            Console.WriteLine("Customer deleted successfully");
        }
    }
    class Customer
    {
        //field
        private string _name;
        //Property
        public int Id { get; set; } 
        public string FirstName 
        { 
            get 
            {
                if (Gender == "Male") return "Mr." + _name;
                else return "Mrs." + _name;            
            }
            set 
            { 
                _name = value;
            }
        }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            if (Gender == "Male") return "Mr." + _name;
            else return "Mrs." + _name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //manager.Add();
            //manager.Update();
            //manager.Delete();

            Customer medine = new Customer();
            medine.Id = 1;
            medine.FirstName = "Medine";
            medine.LastName = "Elizade";
            medine.Address = "Sumqayit";
            medine.Gender = "Female";

            Customer ehmed = new Customer
            {
                Id = 2,
                Address = "Sumqayit",
                FirstName = "Ehmed",
                LastName = "Ehmedov",
                Gender = "Male"
            };

            Customer resad = new Customer
            {
                Id = 3,
                Address = "Baku",
                FirstName = "Resad",
                LastName = "Elizade",
                Gender = "Male"
            };

            //Customer[] customers = new Customer[3];
            //customers[0] = medine;
            //customers[1] = ehmed;
            //customers[2] = resad;

            //foreach (var m in customers)
            //{
            //    Console.WriteLine(m.Id + "\n" + m.Name + "\n" + m.Address+"\n"+m.Gender);
            //}
            CustomerManager manager = new CustomerManager();
            manager.Add(resad);
            //medine.SetName("MEDINE");
            //Console.WriteLine(medine.GetName());

            Customer[] arr = new Customer[2];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Customer
                {
                    Id = int.Parse(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Gender = Console.ReadLine(),
                };
            }

            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Gender);
            }

            //Console.Write("Id: ");
            //arr[i].Id = int.Parse(Console.ReadLine());
            //Console.Write("Firstname: ");
            //arr[i].FirstName = Console.ReadLine();
            //Console.Write("Lastname: ");
            //arr[i].LastName = Console.ReadLine();
            //Console.Write("Gender: ");
            //arr[i].Gender = Console.ReadLine();
        }
    }
}
