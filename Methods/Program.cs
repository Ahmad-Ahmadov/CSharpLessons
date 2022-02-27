using System;

namespace Methods
{
    class Program
    {
        // void => tip döndürməyən
        // int double long float short bool byte string char
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        public static double GetCredit(double mebleg, double faiz = 16)
        {
            return mebleg + (mebleg * faiz) / 100.0;
        }
        public static void PrintHelloByName(string name = "User")
        {
            Console.WriteLine($"Hello {name}");
        }

        public static int Sum()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
                sum += i;
            return sum;          
        }

        //method overloading
        public static int Max(int a,int b)
        {
            if(a > b) return a;
            return b;
        }     
        public static int Max(int a, int b, int c)
        {
            if (a > b & a > c) return a;
            else if (b > a & b > c) return b;
            return c;
        }
        public static string Max(string m, string n)
        {
            if (m.Length > n.Length) return m;
            return n;
        }
        public static bool IsPrimary(object num)
        {
            for (int i = 2; i < (int)num; i++)
                if ((int)num % i == 0) return false;
            return true;           
        }  
        
        public static int CountOfPrimaryNumbers(int a , int b)
        {
            int count = 0;
            bool isPrimary = true;
            for (int i = a; i <= b; i++)
            {
                for(int j = 2; j < i; j++)
                    if(i % j == 0) isPrimary = false;
                if(isPrimary) count++;
                isPrimary = true;
            }
            return count;
        }

        public static int Sum(params int[] value)
        {
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
                sum+=value[i];
            return sum;
        }
        
        static void Main(string[] args)
        {
            //decimal num = 5.6m;
            //float num2 = 5.6F;
            // var object dynamic
            //string m = "Medine";
            //PrintHello();
            //PrintHello();
            //PrintHelloByName("Medine");
            //PrintHelloByName("Ahmad");
            //int d = Sum();
            //Console.WriteLine("SUM {0}",Sum());
            //Console.WriteLine(Max(100,150));
            //Console.WriteLine(Max(100, 100));
            //var num = 5;
            //var name = "hello";
            //var db = 5.6;

            //dynamic mun = 56;

            //object nums = 56; // boxing
            //int numa = Convert.ToInt32(nums); // unboxing
            //Console.WriteLine(nums.GetType().Name);
            //Console.WriteLine(IsPrimary(13));
            //int max = Max(1, 2);
            //Console.WriteLine(max);
            //int max2 = Max(1, 2, 4);
            //Console.WriteLine(max2);
            //Console.WriteLine(Max("Ahmad","Medine"));
            //string name = "Ahmad";
            //bool result = name.StartsWithCustom('a');
            //Console.WriteLine(result);
            //int num = 37;
            //Console.WriteLine(IsPrimary(num));
            //Console.WriteLine(num.IsPrimary()); // extension method
            //string name = "     Ahmad Ahmadov    ";
            //Console.WriteLine(name.TrimCustom());
            //Console.WriteLine(GetCredit(1000));
            //Console.WriteLine(CountOfPrimaryNumbers(2,10));
            //string text = "AHMAD";
            //Console.WriteLine(text.SubStringCustom(0,2));
            int[] nums = { 10, 2, 5, 7, 9, 0, 1, 6, 15, 11, 8, 95 };
            nums.SelectionSort();
            string name;
            Array.ForEach(nums, Console.WriteLine);
        }
        
    }
}
