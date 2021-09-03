using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagoons = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < wagoons; i++)
            {
                int curr = int.Parse(Console.ReadLine());
                sum += curr;

            }
            Console.WriteLine(sum);
        }
    }
}
