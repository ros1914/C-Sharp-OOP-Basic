namespace _04.Opinion_Poll
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			List<Person> persone = new List<Person>();
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(' ');
				string name = input[0];
				int age = int.Parse(input[1]);

				persone.Add(new Person(name, age));

			}

			foreach (var item in persone.Where(p=>p.Age>30).OrderBy(p=>p.Name))
			{
				Console.WriteLine($"{item.Name} - {item.Age}");
			}
		}
	}
}
