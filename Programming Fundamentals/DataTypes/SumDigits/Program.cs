using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currDigit = input[i].ToString();
                int digit = int.Parse(currDigit);
                result += digit;
            }
            Console.WriteLine(result);
        }
    }
}
