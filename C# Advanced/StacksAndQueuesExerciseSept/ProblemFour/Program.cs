using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestOrder = int.MinValue;
            Queue<int> allOrders = new Queue<int>(orders);
            Queue<int> allOrdersCopy = new Queue<int>(orders);
            for (int i = 0; i < orders.Length; i++)
            {
                
                int curr = allOrdersCopy.Dequeue();
                if (curr > biggestOrder)
                {
                    biggestOrder = curr;
                }
            }
            for (int i = 0; i < orders.Length; i++)
            {
                int currentOrder = allOrders.Peek();
                if (foodAmount - currentOrder >= 0)
                {
                    
                    foodAmount -= currentOrder;
                    allOrders.Dequeue();
                }
                else
                {
                    break;
                    
                }
            }
            Console.WriteLine(biggestOrder);
            if (allOrders.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.Write($"Orders left: ");
                while (allOrders.Count != 0)
                {
                    Console.Write($"{allOrders.Dequeue()} ");
                }
            }
        }
    }
}
