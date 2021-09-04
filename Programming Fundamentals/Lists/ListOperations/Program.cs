using System;
using System.Collections.Generic;
using System.Linq;

namespace methodss
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
               else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.Insert(index, number);
                }
               else if (tokens[0] == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    if (number> numbers.Count - 1 || number < 0)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        numbers.RemoveAt(number);
                    }
                }
               else if (tokens[0] == "Shift")
                {
                    if (tokens[1] == "left")
                    {
                        int timesToRotate = int.Parse(tokens[2]);
                        for (int i = 0; i < timesToRotate; i++)
                        {
                            int firstNumb = numbers[0];
                            int lastNumb = numbers[numbers.Count - 1];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNumb);
                        }
                    }
                    if (tokens[1] == "right")
                    {
                        int timesToRotate = int.Parse(tokens[2]);
                        for (int i = 0; i < timesToRotate; i++)
                        {
                            int firstNumb = numbers[0];
                            int lastNumb = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNumb);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
