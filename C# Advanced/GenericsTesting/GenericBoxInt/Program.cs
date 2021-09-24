using System;

namespace GenericBoxInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Box<int> current = new Box<int>(number);
                Console.WriteLine(current.ToString());
            }
        }
    }
}
