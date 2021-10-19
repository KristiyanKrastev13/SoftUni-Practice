using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Roster = new List<Player>();
            Count = 0;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int  Count { get; set; }

        public List<Player> Roster { get; set; }


        public void AddPlayer(Player player)
        {
            if (Roster.Count + 1 <= Capacity)
            {
                Roster.Add(player);
                Count++;
            }
        }
        public bool RemovePlayer(string name)
        {
            bool isThere = Roster.Any(x => x.Name == name);
            
            if (isThere)
            {
                Player toRemove = Roster.First(x => x.Name == name);
                Roster.Remove(toRemove);
                Count--;
                return true;
               
            }
            else
            {
                return false;
            }
        }

        public void PromotePlayer(string name)
        {
            Player currplayer = Roster.First(x => x.Name == name);
            if (currplayer.Rank != "Member")
            {
                currplayer.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player currplayer = Roster.First(x => x.Name == name);
            if (currplayer.Rank != "Trial")
            {
                currplayer.Rank = "Trial";
            }

        }
        public Player[] KickPlayersByClass(string clas)
        {

            List < Player> kicked = Roster.Where(x => x.Class == clas).ToList();
            Player[] sorted = new Player[kicked.Count];
            Roster = Roster.Where(x => x.Class != clas).ToList();
            Count -= kicked.Count;
            for (int i = 0; i < sorted.Length; i++)
            {
                sorted[i] = kicked[i];
            }
            
            
            return sorted;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine($"Players in the guild: {this.Name}");
            foreach (var item in Roster)
            {
                sb.Append(item.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
