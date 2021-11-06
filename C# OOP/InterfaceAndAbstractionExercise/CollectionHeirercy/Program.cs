using System;

namespace CollectionHeirercy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            AddCollection addeble = new AddCollection();
            AddRemoveCollection removable = new AddRemoveCollection();
            MyList list = new MyList();
            string[] itemsToAdd = Console.ReadLine().Split();
            int itemsToRemove = int.Parse(Console.ReadLine());

            foreach (var item in itemsToAdd)
            {
                Console.Write(addeble.Add(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in itemsToAdd)
            {
                Console.Write(removable.Add(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in itemsToAdd)
            {
                Console.Write(list.Add(item) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < itemsToRemove; i++)
            {
                Console.Write(removable.Remove() + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < itemsToRemove; i++)
            {
                Console.Write(list.Remove() + " ");
            }


        }
    }
}
