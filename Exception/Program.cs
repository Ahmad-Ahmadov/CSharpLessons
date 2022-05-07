using System;
using System.Linq;

namespace Exception
{
    internal class MedineException : System.Exception
    {
        public MedineException()
        {
        }
        public MedineException(string message):base(message)
        {
        }
    }
    internal class Program
    {

        static void IsMedine(string name)
        {
            if (name == "Medine") 
                throw new MedineException("Adiniz Medine ola bilmez");
        }

        static void Main(string[] args)
        {
            try
            {
                string m = Console.ReadLine();
                IsMedine(m);
            }
            catch (MedineException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("Daxil etdiniyiz eded deyil");
            }
            Console.ReadLine();
        }
    }
}
