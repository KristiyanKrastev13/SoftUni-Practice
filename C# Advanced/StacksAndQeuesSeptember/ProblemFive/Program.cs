using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> even = new Queue<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Enqueue(numbers[i]);
                }
            }
           while(even.Count != 1)
            {
                Console.Write(even.Dequeue() + "," + " ");
            }
            Console.WriteLine(even.Dequeue());

        }  
    }
}
