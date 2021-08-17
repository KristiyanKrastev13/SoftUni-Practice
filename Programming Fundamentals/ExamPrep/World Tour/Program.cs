using System;
using System.Linq;
using System.Text;

namespace FinalExamPrepration
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            text.Append(input);
            string[] command = Console.ReadLine().Split(":").ToArray();

            while (command[0] != "Travel")
            {
                string action = command[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string place = command[2];

                    if (input.Length > index)
                    {
                        text.Insert(index, place);
                        input = text.ToString();
                    }
                    Console.WriteLine(input);
                }

                if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (input.Length > endIndex)
                    {
                        text.Remove(startIndex, endIndex - startIndex + 1);
                        input = text.ToString();
                    }
                    Console.WriteLine(input);

                }
                if (action == "Switch")
                {
                    string oldString = command[1];
                    string replacement = command[2];

                    while (input.Contains(oldString))
                    {
                        text.Replace(oldString, replacement);
                        input = text.ToString();
                    }
                    Console.WriteLine(input);
                }
                command = Console.ReadLine().Split(":").ToArray();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");


        }
    }
}

