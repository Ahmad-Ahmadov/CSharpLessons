using System;
using System.Linq;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //3
            /*string text = Console.ReadLine();
            string[] words = text.Split();
            string s = words[0], l = words[0];
            foreach (string word in words)
            {
                if (word.Length < s.Length) s = word;
                else if (word.Length > l.Length) l = word;
            }
            Console.WriteLine($"Short: {s}\nLong: {l}");*/

            //4
            //string text = Console.ReadLine();
            //int m = text.IndexOf('m'), n = text.IndexOf('n');
            //if (m != -1 & n != -1)
            //    Console.WriteLine(text.Substring(m, n - m+1));
            //else Console.WriteLine("Not Found");

            //5
            //string[] words = Console.ReadLine().Split(' ');
            //foreach (string word in words)
            //    if (word.Length == 3) Console.Write(word+" ");

            //12
            //string text = Console.ReadLine();
            //char[] m = text.ToCharArray();
            //int count = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (m[i] == 'a' && m[i + 1] == 'b' && m[i + 2] == 'c')
            //        count++;
            //}
            //Console.WriteLine(count);

            //13
            //Console.WriteLine(Console.ReadLine().Split().Length);

            //14
            //string text = Console.ReadLine();
            //int index = text.IndexOf(',');
            //for (int i = 0; i < index; i++)
            //    if (!Char.IsLetter(text[i]) & text[i] != ' ') Console.Write(text[i]+" ");
            //bool result=Char.IsDigit('1');

            //16
            //string text = Console.ReadLine();
            //bool check = true;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if(text[i] != text[text.Length-1-i])
            //    {
            //        check = false;
            //        break;
            //    }
            //}
            //if (check)
            //    Console.WriteLine("TRUE");
            //else Console.WriteLine("FALSE");
            
            
        }
    }
}
