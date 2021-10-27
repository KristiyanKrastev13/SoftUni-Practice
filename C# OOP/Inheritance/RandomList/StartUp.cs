
using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("kica1");
            list.Add("kica2");
            list.Add("kica3");

            Console.WriteLine(list.RandomString());
        }
    }
}
