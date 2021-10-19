using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {

        public Player(string name, string heroclass)
        {
            Name = name;
            Class = heroclass;
            Rank = "Trial";
            Description = "n/a";
        }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank  { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Player {Name}: {Class}");
                sb.Append("\n");
            sb.Append($"Rank: {Rank}");
            sb.Append("\n");
            sb.Append($"Description: {Description}");
            sb.Append("\n");

            return sb.ToString();
        }
    }
}
