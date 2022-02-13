using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Madina Alizada";
            // string-dən verilən indeksdən başlayaraq yeni string yaradır.
            string subText = text.Substring(3, 3);
            // verilən stringdən char array düzəldir
            char[] chars = text.ToCharArray();
            // Verilən ifadənin string-də olub olmadığını yoxlayir
            bool contains = text.Contains("Madina"); 
            // string-in verilən ifadə ilə başlayıb-başlamadığını yoxlayır
            bool startsWith = text.StartsWith("Al");
            // string-in verilən ifadə ilə bitib-bitmədiyini yoxlayır
            bool endsWith = text.EndsWith("ada");
            //sting-in əvvəlinə boşluq əlavə edərək stringin uzunluğunu verilən uzunluğa bərabər edir
            string paddLeft = text.PadLeft(20);
            //sting-in sonuna boşluq əlavə edərək stringin uzunluğunu verilən uzunluğa bərabər edir
            string paddRight = text.PadRight(20);
            // string-in əvvəlində və sonunda olan boşluqları və ya ifadəni silir
            string trim = text.Trim('c');
            //string-in əvvəlində olan boşluqları və ya ifadəni silir
            string trimStart = text.TrimStart();
            string trimEnd = text.TrimEnd();
            // string-dəki herflerin hamısın kiçik hərfə dəyişir
            string toLower = text.ToLower();
            string toUpper = text.ToUpper();
            int indexOf = text.IndexOf('a');
            int lastIndexOf = text.LastIndexOf('M');
            // verilən indeksdən başlayaraq qalan hissəni və ya verilən sayda simvolu silir
            string remove = text.Remove(3,5);
            // göstərilən indeksə verilmiş ifadəni əlavə edir
            string insert = text.Insert(6, "Hello ");
            string[] split = text.Split('a','d');
            string replace = text.Replace('a', 'e').Replace('i','B');
            // empty=>"" null  whitespace=> "    "
            text = "    a      ";
            bool isNullOrEmpty = String.IsNullOrEmpty(text);
            bool isNullOrWhileSpace = String.IsNullOrWhiteSpace(text);
            int m = 123465;
            text = m.ToString();
            Console.WriteLine($"Result: {text.GetType()}");

            // abc abcd a basdasd asda qweqweqas
            /*string text = Console.ReadLine();
            string[] words = text.Split();
            string s = words[0], l=words[0];
            foreach (string word in words)
            {
                if (word.Length < s.Length) s = word;
                else if(word.Length > l.Length) l = word;
            }
            Console.WriteLine($"Short: {s}\nLong: {l}");*/

        }
    }
}
