using System;
using System.Linq;

namespace SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sum = 0;
            int[,] matrix = new int[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                int[] curr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int k = 0; k < size[1]; k++)
                {
                    int currnumb = curr[k];
                    matrix[i, k] = currnumb;
                    sum += currnumb;
                }
            }
            
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);
        }
    }
}
