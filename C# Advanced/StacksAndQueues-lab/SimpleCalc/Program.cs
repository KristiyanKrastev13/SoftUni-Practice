using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            Stack<string> calculator = new Stack<string>(array.Reverse());

            while(calculator.Count > 1)
            {
                int leftOp = int.Parse(calculator.Pop());
                string operation = calculator.Pop();
                int rightOp = int.Parse(calculator.Pop());

                if (operation == "+")
                {
                    calculator.Push((leftOp + rightOp).ToString());
                }
                else
                {
                    calculator.Push((leftOp - rightOp).ToString());
                }
            }

            Console.WriteLine(calculator.Pop());

        }
    }
}
