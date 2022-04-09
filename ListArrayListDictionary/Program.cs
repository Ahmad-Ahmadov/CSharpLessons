using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListArrayListDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 11, 12,13,14,35 };
            //ArrayList m = new ArrayList();
            //m.Add(1);
            //m.Add(2);
            //m.Add(3);
            //m.Add("Medine");
            //m.Add("Ehmed");
            //m.AddRange(nums);
            //Console.WriteLine(m[0]);
            /*
                Bütün elementləri silir
             */
            //m.Clear();
            /*
              ArrayList-in neçə elementdən ibarət oldugunu qaytarır
             */
            //int n = m.Capacity;
            /*
             * Verilən elementin arraylistdə olub-olmadığını yoxlayır
             * /
            bool isContain = m.Contains("resad");
            /*
             verilən indeksdən başlayaraq verilən sayda elementi tərsinə düzür
             */
            //m.Reverse(index,count);
            /*
             * Daxil edilən elementin indexsini qaytarır
             */
            //int index = m.IndexOf(1);
            /*
             * Daxil edilən indexsə verilən elementi daxil edir.
            */
            //m.Insert(0, 100);
            /*
                Verilən indeksdəki elementi silir
             */
            //m.RemoveAt(index);
            //m.Add(2);
            /*
                Qarşılaşdığı ilk uyğun elementi silir
             */
            //m.Remove(2);
            /*
                m.RemoveRange(startIndex,countOfElements)
                verilən indeksdən başlayaraq daxil edilən sayda elementi silir
             */
            //m.RemoveRange(0, 3);
            /*
                m.InsertRange(index,(array,ArrayList,List));
                index-dən başlayaraq verilən (array,ArrayList,List)-dən hər 
                hansını arraylist-ə əlavə edir
             */
            //m.InsertRange(0, nums);

            //foreach (var item in m)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> m = new List<int>();
            //m.Add(0);
            //m.AddRange(nums);
            //var count = m.Count();
            //double avrg = m.Average();
            //Console.WriteLine(count);



            //         key value
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Medine");
            dict.Add(2, "Ehmed");
            dict.Add(15, "Resad");
            
            //Dictionary<string,string> dict2 = new Dictionary<string,string>();
            //dict2.Add("hi", "salam");
            //Console.WriteLine(dict2["hi"]);
            //foreach (var item in dict.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(dict[1]);
            dict[1] = "MEDINE";
            /*
             * Keylərin içərisində daxil edilən key-in olub-olmadığını yoxlayır
            */
            bool c = dict.ContainsKey(1);
            Console.WriteLine(c);
            /*
             * Value-lar içərisində daxil edilən value olub-olmadığını yoxlayır
            */
            bool d = dict.ContainsValue("Medine");
            dict.Remove(1);
            c = dict.ContainsKey(1);
            Console.WriteLine(c);
            //Console.WriteLine(d);
        }
    }
}

//foreach (var item in m)
//{
//    Console.WriteLine(item);
//}