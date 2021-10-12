using System;
using System.Collections.Generic;
using System.Linq;
namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < n; i++)
            {
                int[] actions = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (actions[0] == 1)
                {
                    stack.Push(actions[1]);
                }
                if (actions[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                    
                }
                if (actions[0] == 3)
                {
                    Stack<int> stackReserve = new Stack<int>(stack);
                    int minElement = int.MinValue;
                    for (int k = 0; k < stack.Count; k++)
                    {    
                        int current = stackReserve.Pop();
                        if (current > minElement)
                        {
                            minElement = current;
                        }
                    }
                    Console.WriteLine($"{minElement}");
                    
                }
                if (actions[0] == 4)
                {
                    Stack<int> stackReserve = new Stack<int>(stack);
                    int maxElement = int.MaxValue;
                    for (int k = 0; k < stack.Count; k++)
                    {                       
                        int current = stackReserve.Pop();
                        if (current < maxElement)
                        {
                            maxElement = current;
                        }
                    }
                    Console.WriteLine($"{maxElement}");
                   
                    
                }
            }
            if (stack.Count != 0)
            {
                while(stack.Count != 1)
                {

                    Console.Write($"{stack.Pop()}, ");
                }
                Console.WriteLine($"{stack.Pop()}");
            }
        }
    }
}
