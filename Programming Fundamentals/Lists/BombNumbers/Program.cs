using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = bombNumber[0];
            int times = bombNumber[1];
            int sum = 0;
                       
            for (int i = 0; i < list.Count; i++)
            {
               if (list[i] == bomb)
                 {
                   for (int k = 0; k < times; k++)
                     {
                        int counter = 1;
                      if (i - counter >= 0)
                        {
                          list.RemoveAt(i - counter);
                            counter++;
                            i--;
                        } 
                    }
                    for (int j = 0; j < times; j++)
                    {
                        
                        if (i + 1 <= list.Count - 1)
                        {
                            list.RemoveAt(i + 1);
                            
                        }
                    }
                    int indexOf = list.IndexOf(bomb);
                    list.RemoveAt(indexOf);

                }
                
                
            }

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];

            }
            Console.WriteLine(sum);
                   Console.WriteLine(string.Join(" ", list));
        }
    }
}
