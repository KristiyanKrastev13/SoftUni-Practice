using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int positionOfMatch = 0;
            bool finded = false;
            if (array.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 1; i < array.Length - 1; i++)
                {

                    int leftSum = 0;
                    int rightSum = 0;                  
                    
                    for (int k = i + 1; k < array.Length; k++)
                    {
                        int curr = array[k];
                        rightSum += curr;
                    }
                    for (int j = i - 1; j >= 0; j--)
                    {
                        int currTwo = array[j];
                        leftSum += currTwo;
                    }
                    if (leftSum == rightSum)
                    {
                        positionOfMatch = i;
                        finded = true;
                        break;
                    }
                }
                if (finded)
                {
                    Console.WriteLine(positionOfMatch);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
  
        }
        
    }
}
