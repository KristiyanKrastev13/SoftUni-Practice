using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] telephoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();
            Smartphone smartphone = new Smartphone();
            Stationaty stationaty = new Stationaty();
            
            foreach (var item in telephoneNumbers)
            {
                if (ValidNumber(item))
                {
                    if (item.Length == 10)
                    {
                        smartphone.Call(item);
                    }
                    else if (item.Length == 7)
                    {
                        stationaty.Dail(item);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
   
            }

            foreach (var item in websites)
            {
                if (VaildUrl(item))
                {
                    smartphone.Brows(item);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }

            }
        }
        public static bool ValidNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (!Char.IsDigit(number[i]))
                {
                    return  false;
                }
            }
            return true;
        }
        public static bool VaildUrl(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (Char.IsDigit(url[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
