using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {

        HashSet<Person> people;

        public Family()
        {
            this.people = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            Person person = this.people.OrderByDescending(x => x.Age).FirstOrDefault();

            return person;
        }

        public HashSet<Person> AgeIsMoreThan30()
        {
            HashSet<Person> person = people.Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToHashSet();

            return person;
        }
    }
}
