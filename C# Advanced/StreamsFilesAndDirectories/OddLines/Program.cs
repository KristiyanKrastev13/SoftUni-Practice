using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
           using(StreamReader reader = new StreamReader(@"../../../input.txt"))
            {
                string current = reader.ReadLine();
                int row = 0;
                while (current != null)
                {
                    if (row % 2== 0)
                    {
                        Console.WriteLine(current);
                    }
                    
                    current = reader.ReadLine();
                    row++;
                }
            }
           
        }
    }
}
