using System.Collections.Generic;
using System.Linq;

namespace _03.Oldest_Family_Member
{
	public class Family
	{
		public Family()
		{
			this.people = new List<Person>();
		}
		public ICollection<Person> people { get; set; }

		public void AddMember(Person member)
		{
			 this.people.Add(member);
		}

		public Person GetOldestMember()
		{
			return this.people.OrderByDescending(p => p.Age).First();
		}

	}
}
