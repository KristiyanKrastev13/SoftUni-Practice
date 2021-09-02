using System;
using System.Linq;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string left = input[0];
                string right = input[1];
                int leftSum = 0;
                int rightSum = 0;
                for (int k = 0; k < left.Length; k++)
                {
                    string curr = left[k].ToString();
                    if (Char.IsDigit(left[k]))
                    {
                        int currNumb = int.Parse(curr);
                        leftSum += currNumb;
                    }
                    else
                    {
                        string currec = left[k+1].ToString();
                        int currNumbA = int.Parse(currec);
                        leftSum -= currNumbA;
                        k++;
                    }     
                }
                for (int j = 0; j < right.Length; j++)
                {
                    string curr = right[j].ToString();
                    if (Char.IsDigit(right[j]))
                    {
                        int currNumb = int.Parse(curr);
                        rightSum += currNumb;
                    }
                    else
                    {
                        string currec = left[j + 1].ToString();
                        int currNumbA = int.Parse(currec);
                        leftSum -= currNumbA;
                        j++;
                    }
                    
                }
                if (leftSum > rightSum)
                {
                    Console.WriteLine(leftSum);
                }
                else
                {
                    Console.WriteLine(rightSum);
                }

            }
        }
    }
}
