using System;

namespace RefOutKeyword
{
    static class Class1
    {
        public static int IndexOfCustom(this int[] nums, int num)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                    return i;
            }
            return -1;
        }
        public static int LastIndexOfCustom(this int[] nums, int num)
        {
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] == num)
                    return i;
            }
            return -1;
        }
        
        public static void SelectionSort(this int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                for (int j = i; j < nums.Length; j++)
                {
                    
                    if (nums[j] < nums[i])
                    {
                        nums[i] = nums[j];
                        nums[j] = n;
                        n = nums[i];
                    }

                }
            }
        }
        public static int MaxCustom(this int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {                
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }
        public static int PowCustom(this int x, int y)
        {
            for (int i = 0; i < y; i++)
                x *= x;
            return x;
        }
        public static void ReverseCustom(int[] nums)
        {
            int n = nums.Length-1;
            int m;
            for (int i = 0; i < nums.Length/2; i++)
            {
                m = nums[i];
                nums[i] = nums[n-i];
                nums[n-i] = m;
            }
        }
        public static string ReplaceCustom(this string text, char h, char f)
        {
            string str = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == h)
                    str += f;
                else str += text[i];
            }            
            return str;
        }

        public static string InsertCustom(this string text, int n, string text1)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += text[i];
            }
            str += text1;
            for (int i = n ; i < text.Length; i++)
            {
                str += text[i];
            }
            return str;
        }

        public static double Sqrt(double num)
        {
            double i;
            for (i = 0; i * i <= num; i += 0.00001) ;
            return i-0.00001;   
        }
    }
    class Program
    {
        public static void Change(ref int a)
        {
            
        }

        public static void ChangeB(out int a)
        {
            a = 500; 
        }
        public static void Change(int[] nums)
        {
            nums[0] = 100;
            nums[1] = 500;
        }

        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3 };
            //int[] b = { 4, 5, 6 };
            //string[] words = { "Salam", "Hello", "World" };
            //var word = String.Join(" ", "Salam", "Hello", "World");
            //word = String.Concat("@", word,"Parameter");
            //a[0] = 10;
            ////Console.WriteLine(a[0]);
            ////Console.WriteLine(b[0]);
            //a = b;
            //a[0] = 15;
            //int m=0;
            ////Console.WriteLine(a[0]);
            ////Change(a);
            //Change(ref m);
            //Console.WriteLine(m);
            //ChangeB(out m);
            ////Console.WriteLine(a[0]);
            ////Console.WriteLine(a[1]);
            //Console.WriteLine(word);
            //Console.WriteLine(text);
            int[] nums = { 1, 20, 3, 0, 5, 4, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            nums.SelectionSort();
            Array.ForEach(nums, Console.WriteLine);
        }
    }
}
