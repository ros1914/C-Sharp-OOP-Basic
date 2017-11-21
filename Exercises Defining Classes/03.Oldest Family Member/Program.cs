namespace _03.Oldest_Family_Member
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
			MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
			if (oldestMemberMethod == null || addMemberMethod == null)
			{
				throw new Exception();
			}


			int n = int.Parse(Console.ReadLine());
			Family persone = new Family();
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(' ');
				string name = input[0];
				int age = int.Parse(input[1]);

				persone.AddMember( new Person(name,age));
				 
			}

			var oldest = persone.GetOldestMember();
			Console.WriteLine($"{oldest.Name} {oldest.Age}");
		}
	}
}
