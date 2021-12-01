using System;
using System.Collections.Generic;

namespace GenericsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);

            Console.WriteLine(list[1]);
        }
    }
}
