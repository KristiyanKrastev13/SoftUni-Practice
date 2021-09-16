using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {

        private List<Person> Members;
        public Family()
        {
            Members = new List<Person>();
        }
        

        public void  AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person olderstMember = Members.OrderByDescending(m => m.Age).FirstOrDefault();
            return olderstMember;
        }
    }
}
