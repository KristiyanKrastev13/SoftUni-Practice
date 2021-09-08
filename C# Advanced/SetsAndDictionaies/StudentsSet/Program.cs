using System;
using System.Collections.Generic;

namespace StudentsSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> students = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                students.Add(input);
            }

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
