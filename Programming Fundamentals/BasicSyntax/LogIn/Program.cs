using System;
using System.Linq;

namespace LogIn
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] passwordCreator = username.ToCharArray();
            Array.Reverse(passwordCreator);
            string password = new string(passwordCreator);
           

            for (int i = 0; i < 4; i++)
            {
                string passInput = Console.ReadLine();
                if (passInput == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }                 
                }

            }
        }
    }
}
