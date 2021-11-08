﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
   public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            Power = 100;
        }

        public override string Name { get ; set; }
        public override int Power { get; set; }
        public override string CastAbility()
        {
            return $"Warrior - {Name} hit for {Power} damage";
        }
    }
    
}
