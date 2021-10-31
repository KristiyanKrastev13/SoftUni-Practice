using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> person = new Dictionary<string, Person>();
            Dictionary<string, Product> product = new Dictionary<string, Product>();
            try
            {
                var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in input)
                {
                    var splited = item.Split('=');
                    var name = splited[0];
                    var money = double.Parse(splited[1]);
                    person.Add(name, new Person(name, money));

                }
                var inputProdcut = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in inputProdcut)
                {
                    var splited = item.Split('=');
                    var name = splited[0];
                    var money = double.Parse(splited[1]);
                    product.Add(name, new Product(name, money));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
                
                               
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] splitted = command.Split();
                var personName = splitted[0];
                var productName = splitted[1];

                if (person.ContainsKey(personName) && product.ContainsKey(productName))
                {
                    try
                    {
                        person[personName].BuyProduct(product[productName]);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);                       
                    }
                                              
                }
            }

            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            
        }


        
       
    }
}
