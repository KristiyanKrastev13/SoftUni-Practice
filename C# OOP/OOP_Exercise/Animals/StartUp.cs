using System;
using System.Collections.Generic;

namespace Animals
{
   public class StartUp
    {
        
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();
            List<Animal> animals = new List<Animal>();
            while (animalType != "Beast!")
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);                
                string gender = data[2];
                try
                {
                    if (animalType == "Cat" && gender == "Male")
                    {
                        Tomcat cat = new Tomcat(name, age, gender);
                        animals.Add(cat);
                    }
                    else if (animalType == "Cat" && gender == "Female")
                    {
                        Kitten kitten = new Kitten(name, age, gender);
                        animals.Add(kitten);
                    }
                    else if (animalType == "Cat" && gender == "Tomcat")
                    {
                        Tomcat cat = new Tomcat(name, age, "Male");
                        animals.Add(cat);
                    }
                    else if (animalType == "Cat" && gender == "Kitten")
                    {
                        Kitten kitten = new Kitten(name, age, "Female");
                        animals.Add(kitten);
                    }
                    if (animalType == "Dog")
                    {

                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex);
                }
               
                animalType = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                animal.ProduceSound();
            }
        }
    }
}
