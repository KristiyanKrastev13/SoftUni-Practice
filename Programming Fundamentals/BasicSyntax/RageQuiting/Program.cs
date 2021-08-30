using System;

namespace RageQuiting
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headseatPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headseatCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headseatCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }
            double endPrice = (headseatCount * headseatPrice) + (mouseCount * mousePrice) + (keyboardCount * keyboardPrice) + (displayCount * displayPrice);
            Console.WriteLine($"Rage expenses: {endPrice:f2} lv.");
            
        }
    }
}
