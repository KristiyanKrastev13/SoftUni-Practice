using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int currFirst = array[0];
                for (int k = 0; k < array.Length-1; k++)
                {                  
                    array[k] = array[k + 1];
                }
                array[array.Length - 1] = currFirst;               
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
