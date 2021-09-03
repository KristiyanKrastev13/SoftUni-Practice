using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < secondArray.Length; i++)
            {
                string currentElement = secondArray[i];
                for (int k = 0; k < firstArray.Length; k++)
                {
                    string currentComparison = firstArray[k];
                    if (currentElement == currentComparison)
                    {
                        Console.Write(currentElement + " ");
                    }

                }
            }
        }
    }
}
