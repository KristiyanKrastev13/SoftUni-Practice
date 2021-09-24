using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapInt
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> list = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentInt = int.Parse(Console.ReadLine());
                Box<int> currBox = new Box<int>(currentInt);
                list.Add(currBox);

            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapElements(indexes[0], indexes[1], list);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Value.GetType()}: {item.Value}");
            }



        }
        public static void SwapElements(int firstElement, int secondElement, List<Box<int>> list)
        {
            if (firstElement >= list.Count || secondElement >= list.Count)
            {
                return;
            }
            else
            {
                Box<int> elementForChange = list[firstElement];
                list[firstElement] = list[secondElement];
                list[secondElement] = elementForChange;
            }


        }
    }
    
}
