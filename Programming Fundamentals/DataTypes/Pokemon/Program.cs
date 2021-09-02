using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int originalPokePower = pokePower;
            int distanceBetweenTargers = int.Parse(Console.ReadLine());
            int exhaustinFactopr = int.Parse(Console.ReadLine());
            int targersPoked = 0;
            double percents = originalPokePower / 2;

            while (pokePower >= distanceBetweenTargers)
            {         
                if (pokePower == originalPokePower / 2)
                {
                    pokePower = pokePower / exhaustinFactopr;
                }
                else
                {
                    pokePower -= distanceBetweenTargers;
                    targersPoked++;
                }       
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targersPoked);

        }
    }
}
