using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ExamPoint { get; set; }
        public int Average { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> m = new List<Student>();
            m.AddRange(new Student[]
            {
                new Student
                {
                    Id = 1,
                    Name = "Ehmed",
                    Surname = "Ahmadov",
                    ExamPoint = 90,
                    Average = 87
                },
                new Student
                {
                    Id = 2,
                    Name = "Madina",
                    Surname = "Alizada",
                    ExamPoint = 100,
                    Average = 95
                },
                new Student
                {
                    Id = 3,
                    Name = "Resad",
                    Surname = "Elizade",
                    ExamPoint = 95,
                    Average = 90
                },
                new Student
                {
                    Id = 4,
                    Name = "Cemale",
                    Surname = "Ehmedova",
                    ExamPoint = 80,
                    Average = 81
                }
            });
            int[] nums = { 1, 2, 3, 4, 42, 5, 1, 2, 3, 4, 8, 6, 9, 7, 7, 7, 8 };
            //List<string> names = new List<string>();
            //foreach (var n in m)
            //{
            //    if(n.Name.Contains("a"))
            //        names.Add(n.Name);
            //}
            //Array.ForEach(names.ToArray(), Console.WriteLine);

            //lambda
            var result = m.Select(p => p.Name);
            var result2 = m.Where(p => p.Name.Contains('a') & p.ExamPoint > 90).Select(p => p.Name).ToArray();
            var result3 = m.Count(p => !p.Name.Contains('a') & p.Average < 60);
            var result4 = m.Where(p => p.ExamPoint > 90).Select(p => p.ExamPoint);
            var result5 = m.Sum(p => p.Id + p.ExamPoint + p.Average);
            var result6 = m.Sum(p => p.Name.Length + p.Surname.Length);
            var result7 = m.Where(p => p.ExamPoint > 90).Select(p => p.Name.Length + p.Average);
            var result8 = m.Max(p => p.Name.Length);
            var result9 = m.Min(p => p.ExamPoint);
            var result10 = m.OrderBy(p => p.Name[1]).ToArray();
            var result11 = m.FindLast(p => p.ExamPoint > 90);
            var result12 = m.FindAll(p => p.Average > 85);
            var result13 = m.Find(p => p.Average > 85);
            var result14 = nums.Distinct().OrderBy(p => p);
            var result15 = m.FirstOrDefault(p=>p.ExamPoint>90);
            var result16 = m.SingleOrDefault(p => p.ExamPoint >95);
            Console.WriteLine(result16.Name);
            Array.ForEach(result14.ToArray(), Console.WriteLine);          
        }
    }
}