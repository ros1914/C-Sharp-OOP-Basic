using System.Collections.Generic;
using System.Linq;

namespace _04.Opinion_Poll
{
	public class Family
	{
		public Family()
		{
			this.peopl = new List<Person>();
		}
		public ICollection<Person> peopl { get; set; }
	
		public void AddMember(Person member)
		{
			this.peopl.Add(member);
		}

		public Person GetOldestMember()
		{
			return this.peopl.OrderByDescending(p => p.Age).First();
		}

		//public Person GetMemberMoreThenThirty()
		//{
		//	return this.peopl;
		//}
	}
}
