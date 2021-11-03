using System;

namespace Pizza
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaName = Console.ReadLine().Split();
            string pizzaNameSplitted = pizzaName[1];
            string[] doughInput = Console.ReadLine().Split();
            string doughtType = doughInput[1];
            string doughTechnique = doughInput[2];
            int doughGrams = int.Parse(doughInput[3]);
            try
            {
                Pizza pizza = new Pizza(pizzaNameSplitted, new Dough(doughtType, doughTechnique, doughGrams));

                while (true)
                {
                    string[] toppings = Console.ReadLine().Split();
                    if (toppings[0] == "END")
                    {
                        break;
                    }
                    Topping top = new Topping(toppings[1], int.Parse(toppings[2]));
                    pizza.AddTopping(top);

                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
            

        
    
}
