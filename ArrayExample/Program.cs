using System;
using System.Linq;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //904
            /*int n = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            for (int i = 0; i < n-1; i++)
            {
                if (nums[i] >= 0) Console.Write((nums[i] + 2) + " ");
                else Console.Write(nums[i]+ " ");
            }
            if (nums[n - 1] >= 0) Console.Write((nums[n - 1] + 2));
            else Console.Write(nums[n - 1]);*/

            //907
            /*int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            bool m = true;
            for(int i = 0; i < n; i++)
            {
                if (double.Parse(arr[i]) <= 2.5)
                {
                    m = false;
                    Console.WriteLine("{0} {1:F2)", i + 1, double.Parse(arr[i]));
                    break;
                }
            }
            if(m) Console.WriteLine("Not Found");*/

            //914
            //int n = int.Parse(Console.ReadLine());
            //double[] nums = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            //Console.WriteLine("{0:F2}",Math.Max(Math.Abs(nums.Max()),Math.Abs(nums.Min())));


            //917
            int n = int.Parse(Console.ReadLine());
            double[] nums = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            Console.WriteLine("{0:F2}", nums.Min() * 2);
            Array.Sort(nums);
        }
    }
}
