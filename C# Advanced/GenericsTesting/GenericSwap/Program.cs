using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwap
{
 public   class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> list = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();
                Box<string> currBox = new Box<string>(currentString);
                list.Add(currBox);

            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapElements(indexes[0], indexes[1], list);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Value.GetType()}: {item.Value}");
            }


           
        }
        public static void SwapElements(int firstElement, int secondElement, List<Box<string>> list)
        {
            if (firstElement >= list.Count || secondElement >= list.Count)
            {
                return;
            }
            else
            {
                Box<string> elementForChange = list[firstElement];
                list[firstElement] = list[secondElement];
                list[secondElement] = elementForChange;
            }

            
        }
    }
}
