using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private int age;
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name { get; set; }
        public int Age {
            get
            {
                return this.age;
            }
           private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public string Gender { get; set; }

        public virtual void ProduceSound()
        {

        }
    }


}
