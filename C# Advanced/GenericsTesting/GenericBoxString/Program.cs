using System;

namespace GenericBoxString
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<string> current = new Box<string>(Console.ReadLine());
                Console.WriteLine(current.ToString());
            }
        }
    }
}
