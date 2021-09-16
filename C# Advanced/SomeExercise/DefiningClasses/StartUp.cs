using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> filter = new List<Person>();
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person currPerson = new Person(name, age);
                filter.Add(currPerson);
         
            }

             filter = filter.Where(p => p.Age >= 30).OrderBy(p => p.Name).ToList();

            foreach (var item in filter)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }

        }
    }
}
