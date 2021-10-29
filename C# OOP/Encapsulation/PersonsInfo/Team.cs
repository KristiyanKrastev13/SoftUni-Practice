using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public Team(string name)
        {
            Name = name;
            FirstTeam = new List<Person>();
            ReserveTeam = new List<Person>();
        }
        public string  Name { get; private set; }
        public List<Person> FirstTeam { get;  }
        public List<Person> ReserveTeam { get; }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                FirstTeam.Add(person);
            }
            else
            {
                ReserveTeam.Add(person);
            }
        }
    }
}
