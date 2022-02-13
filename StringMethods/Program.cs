using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Madina Alizada";
            string subText = text.Substring(3, 3);
            char[] chars = text.ToCharArray();
            bool contains = text.Contains("Madina");
            bool startsWith = text.StartsWith("Al");
            bool endsWith = text.EndsWith("ada");
            string paddLeft = text.PadLeft(20);
            string paddRight = text.PadRight(20);
            string trim = text.Trim();
            string trimStart = text.TrimStart();
            string trimEnd = text.TrimEnd();
            string toLower = text.ToLower();
            string toUpper = text.ToUpper();
            int indexOf = text.IndexOf('a');
            int lastIndexOf = text.LastIndexOf('M');
            string remove = text.Remove(3,5);
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
        }
    }
}
