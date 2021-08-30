using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int convertingNumber = int.Parse(number);
            int endResult = 0;

            for (int i = 0; i < number.Length; i++)
            {               
                int currnumber = (int)Char.GetNumericValue(number[i]);
                if (currnumber == 0)
                {
                    endResult += 1;
                    continue;
                }
                int currResult = currnumber;

                for (int k = currnumber - 1; k > 1; k--)
                {
                    currResult = currResult * k;
                }
                endResult += currResult;
            }
            if (endResult == convertingNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
