using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
   public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstname, string lastname, int age, decimal salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Salaty = salary;

        }
        public string FirstName {
            get => this.firstName;

           private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string  LastName {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public int Age {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public decimal Salaty {
            get => this.salary;

            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salaty:f2} leva.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salaty = Salaty + (Salaty * percentage / 100);
            }
            else
            {
                this.Salaty = Salaty + (Salaty * percentage / 200);
            }
            
        }

    }
}
