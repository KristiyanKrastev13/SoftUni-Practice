using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int liftCompacity = int.Parse(Console.ReadLine());
            int courses = 0;
            
            while(peopleCount != 0)
            {
                if (peopleCount < liftCompacity)
                {
                    peopleCount = 0;
                    courses++;
                }
                else
                {
                    peopleCount = peopleCount - liftCompacity;
                    courses++;
                }
            }
            Console.WriteLine(courses);

        }
    }
}
