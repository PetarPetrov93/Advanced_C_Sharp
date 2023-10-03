using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyList;

        public Family()
        {
            FamilyList = new List<Person>();
        }

        public List<Person> FamilyList
        { 
            get { return familyList; }
            set { familyList = value; }
        }

        public void AddMember (Person member)
        {
            FamilyList.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxAge = this.FamilyList.Max(member => member.Age);
            return this.FamilyList.First(member => member.Age == maxAge);
        }

        internal IEnumerable<Person> Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
