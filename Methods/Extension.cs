using System;
using System.Linq;

namespace Methods
{
    public static class Extension
    {
        public static bool StartsWithCustom(this string text,char ch)
        {
            if(text[0]==ch) return true;
            return false;
        }

        public static bool IsPrimary(this int m)
        {
            for (int i = 2; i < m; i++)
            {
                if (m % i == 0)
                    return false;
            }
            return true;
        }

        public static string SubstringCustom(this string text, int index)
        {
            string subString = "";
            for (int i = index; i < text.Length; i++)
                subString += text[i];
            return subString;
        }

        public static bool ContainsCustom(this string text,char ch)
        {
            for (int i = 0; i < text.Length; i++)
                if (text[i] == ch) return true;
            return false ;           
        }

        public static string TrimCustom(this string text)
        {
            string str = "";
            for(int i = 2; i < text.Length-2; i++)
            {
                if (text[i - 2] != ' ' & text[i - 1] == ' ' & text[i] != ' ') str += " " + text[i];
                else if(text[i]!=' ')str+=text[i];                              
            }
            return str;
        }

        public static string PaddRighCustom(this string text, int count)
        {
            string str = "";
            int ferq = count - text.Length;
            for (int i = 0; i < ferq; i++)
            {
                str += " ";
            }
            string t = text + str;
            return t;
        }
        public static string PaddLeftCustom(this string text, int count)
        {
            string str = "";
            int ferq = count - text.Length;
            for (int i = 0; i < ferq; i++)
            {
                str += " ";
            }
            string t = str + text;
            return t;
        }

        public static bool ContainsCustom(this string text, string text2)
        {
            for (int i = text2.Length; i < text.Length; i++)            
                if (text.Substring(i - text2.Length, text2.Length) == text2) return true;            
            return false;
        }
        public static int IndexOfCustom(this string text, char ch)
        {
            for (int i = 0; i < text.Length; i++)           
                if (text[i] == ch) return i;           
            return -1;
        }
        public static string SubStringCustom(this string text, int index, int length)
        {
            string str = "";
            for(int i = index,k=0; k < length; i++,k++)            
                str += text[i];            
            return str;
        }

        public static bool EndsWithCustom(this string text,string value)
        {
            if(text.SubStringCustom(text.Length - value.Length, value.Length) == value) return true;
            return false;
        }

        public static void SelectionSort(this int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {               
                for (int j = i; j < nums.Length; j++)
                {
                    int m = nums[i];
                    if (nums[i] > nums[j])
                    {
                        nums[i] = nums[j];
                        nums[j] = m;
                    }
                }
            }
        }

        //bubble sort , insertion sort
    }
}
