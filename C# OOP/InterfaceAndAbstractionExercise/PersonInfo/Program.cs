using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            int totalFood = 0;


            for (int i = 0; i < n; i++)
            {
                string[] currInput = Console.ReadLine().Split();
                if (currInput.Length == 4)
                {
                    citizens.Add(new Citizen(currInput[0], int.Parse(currInput[1]), currInput[2], currInput[3]));
                }
                else
                {
                    rebels.Add(new Rebel(currInput[0], int.Parse(currInput[1]), currInput[2]));
                }
            }
            while (true)
            {
                
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }
                Citizen curr = citizens.FirstOrDefault(x => x.Name == name);
                if (curr != null)
                {
                    curr.BuyFood();                   
                    continue;
                }
                Rebel currReb = rebels.FirstOrDefault(x => x.Name == name);
                if (currReb != null)
                {
                    currReb.BuyFood();
                }

            }
            foreach (var item in citizens)
            {
                totalFood += item.Food;
            }
            foreach (var item in rebels)
            {
                totalFood += item.Food;
            }

            Console.WriteLine(totalFood) ;
        }
    }
}
