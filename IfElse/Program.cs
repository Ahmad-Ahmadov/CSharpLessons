using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int x=nums[0];
            int a=nums[1];
            int b=nums[2];
            if (x >= a && x <= b)
                Console.WriteLine("IN");
            else
                Console.WriteLine("OUT");
                
        }
    }
}
