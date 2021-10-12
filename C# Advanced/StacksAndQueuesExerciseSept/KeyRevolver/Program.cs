using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfPrice = int.Parse(Console.ReadLine());
            Stack<int> locksQ = new Stack<int>(locks.Reverse());
            Queue<int> bulletsQ = new Queue<int>(bullets.Reverse());
            int counter = 0;
            int bulletShot = 0;
            bool opened = false;
            while (bulletsQ.Count != 0)
            {
                
                int currentBullet = bulletsQ.Dequeue();
                int currentLock = locksQ.Peek();
                bulletShot++;
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine($"Bang!");
                    locksQ.Pop();
                   
                    
                }
                else
                {
                    Console.WriteLine($"Ping!");
                }
                counter++;
                
                if (counter == gunBarrelSize && bulletsQ.Count > 0)
                {
                    Console.WriteLine($"Reloading!");
                    counter = 0;
                }
                if (locksQ.Count == 0)
                {
                    opened = true;
                    break;
                }
            }
            if (opened)
            {
                int moneyEarned = valueOfPrice - (bulletShot * bulletPrice);
                Console.WriteLine($"{bulletsQ.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQ.Count}");
            }

        }
    }
}
