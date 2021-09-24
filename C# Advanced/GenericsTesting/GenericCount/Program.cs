using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCount
{
  public  class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> list = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currElement = Console.ReadLine();
                Box<string> currBox = new Box<string>(currElement);
                list.Add(currBox);
            }

            string value = Console.ReadLine();
            int result = GetBiggestElementsCount(value, list);
            Console.WriteLine(result);


        }

        public static int GetBiggestElementsCount<T>(T value, List<Box<T>> boxes)
            where T : IComparable
        {
            return boxes.Where(b => b.Value.CompareTo(value) > 0).ToList().Count;

        }
    }
}
