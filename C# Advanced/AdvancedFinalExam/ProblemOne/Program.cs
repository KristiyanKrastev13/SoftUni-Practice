using System;
using System.Collections.Generic;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputVowes = Console.ReadLine();
            Queue<char> vowes = new Queue<char>();
            for (int z = 0; z < inputVowes.Length;z++)
            {
                if (inputVowes[z] != ' ')
                {
                    vowes.Enqueue(inputVowes[z]);
                }
            }
            string inputOthers = Console.ReadLine();
            Queue<char> others = new Queue<char>();
            for (int j = inputOthers.Length- 1; j >= 0; j--)
            {
                if (inputOthers[j] != ' ')
                {
                    others.Enqueue(inputOthers[j]);
                }
            }
            bool pear = false;
            bool flour = false;
            bool pork = false;
            bool olive = false;
            int counter = 0;

            bool p = false;
            bool f = false;
            bool r = false;
            bool l = false;
            bool k = false;
            bool v = false;
            bool e = false;
            bool a = false;
            bool o = false;
            bool i = false;
            bool u = false;

            while (others.Count != 0)
            {
                char currVowel = vowes.Dequeue();
                char currCons = others.Dequeue();
                if (currVowel == 'e')               
                     e = true;
                if (currVowel == 'u')
                    u = true;
                if (currVowel == 'a')
                    a = true;               
                if (currVowel == 'o')              
                    o = true;               
                if (currVowel == 'i')               
                    i = true;
                if (currCons == 'p')
                    p = true;
                if (currCons == 'f')
                    f = true;
                if (currCons == 'r')
                    r = true;
                if (currCons == 'l')
                    l = true;
                if (currCons == 'k')
                    k = true;
                if (currCons == 'v')
                    v = true;
                vowes.Enqueue(currVowel);

            }
            if (p && e && a && r)
            {
                pear = true;
                counter++;
            }

            if (f && l && o && u && r)
            { 
                flour = true;
                counter++;
                    }
            if (p && o && r && k)
            {
                pork = true;
                counter++;
            }

            if (o && l && i && v && e)
            {
                olive = true;
                counter++;
            }
            Console.WriteLine($"Words found: {counter}");

            if (pear)
            {
                Console.WriteLine("pear");
            }
            if (flour)
            {
                Console.WriteLine("flour");
            }
            if (pork)
            {
                Console.WriteLine("pork");
            }
            if (olive)
            {
                Console.WriteLine("olive");
            }

        }
    }
}
