using System;

namespace TrippleLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a' + n; i++)
            {
                char currA = (char)i;
                for (int k = 'a'; k < 'a'+n; k++)
                {
                    char currB = (char)k;
                    for (int j = 'a'; j < 'a' + n; j++)
                    {
                        char currC = (char)j;
                        Console.WriteLine($"{currA}{currB}{currC}");
                    }
                }
                
            }
        }
        
    }
}
