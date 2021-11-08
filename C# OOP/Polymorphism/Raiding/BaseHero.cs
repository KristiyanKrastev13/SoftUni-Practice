using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        
        public BaseHero(string name)
        {
            Name = name;
            
        }
       public abstract string Name { get; set; }
       public abstract int Power { get; set; }
      

        public virtual string CastAbility()
        {
            return "";
        }
    }
}
