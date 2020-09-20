using System;
using System.Collections.Generic;
using StudentsCount.Entities;

namespace StudentsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();
            Console.Write("How many students of course A? ");
            int A = int.Parse(Console.ReadLine());
            for (int i = 0; i < A; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(new Student(x));
            }
            Console.Write("How many students of course B? ");
            int B = int.Parse(Console.ReadLine());
            for (int i = 0; i < B; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(new Student(x));
            }
            Console.Write("How many students of course C? ");
            int C = int.Parse(Console.ReadLine());
            for (int i = 0; i < C; i++)
            {
                int x = int.Parse(Console.ReadLine());
                set.Add(new Student(x));
            }
            Console.Write("Total students: " + set.Count);
            Console.ReadLine();
        }
    }
}
