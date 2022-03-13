using System;
using System.Linq;

namespace ArrayLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            
           // nums[0] = int.Parse(Console.ReadLine());
            /*int[] numbers = new int[5];
            int[] array = new int[5] { 2, 5, 4, 6, 7 };
            string text = "Madina";
            //text[0] = 'a'; // immutable & mutable
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            Array.Sort(nums); 
            Array.Reverse(nums);
            Array.IndexOf(nums, 3); // ilk tapdığı indeksi qaytarır (əvvəldən)
            Array.LastIndexOf(nums, 3); // sondan ilk tapdığı indeksi qaytarır
            Array.ForEach(nums,Console.WriteLine);
            Array.Clear(nums, 3, 2);
            Array.Copy(array, numbers,array.Length);
            Console.WriteLine(text[0]);
            //Array.ConvertAll
            /*string[] num = Console.ReadLine().Split();
            int[] nums2 = new int[num.Length];
            int i = 0;
            // converter: int.Parse
            string text2 = "MEdine";
            foreach(string m in num)
            {
                nums2[i] = int.Parse(m);
                i++;
            }
            

            int[,] matris = new int[3, 3];
            for (int n = 0; n <= matris.GetUpperBound(0); n++)
            {
                for (int m = 0; m <= matris.GetUpperBound(1); m++)
                {
                    matris[n, m] = m;
                }
            }

            for (int n = 0; n <= matris.GetUpperBound(0); n++)
            {
                for (int m = 0; m <= matris.GetUpperBound(1); m++)
                {
                    Console.Write($"{matris[n,m]} ");// string interpolation
                }
                Console.WriteLine();
            }*/
            /*int[] nums = { 1, 2, 3, 4, 5, 7, 8, 7, 89 };
            foreach(int m in nums)
                Console.WriteLine(m);*/
            /*int[,] m = new int[5, 5]; 
            for (int i = 0; i < 5; i++)
            {
                var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < 5; j++)
                {
                    m[i,j] = nums[j];
                }
            }

            Console.WriteLine();
            for (int i = 0; i <= m.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= m.GetUpperBound(1); j++)
                {
                    Console.Write($"{m[i, j]} ");// string interpolation
                }
                Console.WriteLine();
            }*/

            //int y = 0;
            //int x = ++y;
            //Console.WriteLine(y);
            ////int z = ++y;
            //Console.WriteLine(x);

           // int n = int.Parse(Console.ReadLine());
           // int[,] m = new int[n, n];

            /*for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                        m[i, j] = j + 1;
                }
                else
                {
                    for (int j = 0; j < n; j++)
                        m[i, j] = n-j;
                }
            }*/

            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1- i) m[i, j] = n - i;
                    else m[i, j] = 0;
                }
            }

            for (int i = 0; i <= m.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= m.GetUpperBound(1); j++)
                {
                    Console.Write($"{m[i, j]} ");// string interpolation
                }
                Console.WriteLine();
            }*/
            double dist = double.Parse(Console.ReadLine());
            double day = 10, total = 10;
            int count = 0;

            do
            {
                total += day;
                day = day + day / 10.0;
                count++;
            } while (total <= dist);

            Console.WriteLine(count);
        }
    }
}
