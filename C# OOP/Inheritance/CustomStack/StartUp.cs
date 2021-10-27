using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
   public class StartUp

    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("aa");
            list.Add("ab");
            list.Add("ac");
            list.Add("ad");

            StackOfStrings stack = new StackOfStrings();
            stack.AddRange(list);

            while (stack.Any())
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}
