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
    }
}
