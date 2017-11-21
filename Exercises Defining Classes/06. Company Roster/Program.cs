namespace _06.Company_Roster
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
			List<Employee> employee = new List<Employee>();
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(' ');

				string name = input[0];
				double salary = double.Parse(input[1]);
				string position = input[2];
				string department = input[3];
				

				var hora = new Employee(name, salary, position, department);


				if (input.Length > 4)
				{
					if (input[4].Contains("@"))
					{
						hora.Email = input[4];
					}
					else
					{
						hora.Age = int.Parse(input[4]);
					}
				}
				if (input.Length > 5)
				{
					hora.Age = int.Parse(input[5]);

				}

				employee.Add(hora);
			}

			var result = employee.GroupBy(g => g.Department).Select(s => new
			{
				Departmant = s.Key,
				AverageSalary = s.Average(emp => emp.Salary),
				Employees = s.OrderByDescending(emp => emp.Salary)


			}).OrderByDescending(f => f.AverageSalary).First();

			Console.WriteLine($"Highest Average Salary: {result.Departmant}");

			foreach (var res in result.Employees)
			{
				Console.WriteLine($"{res.Name} {res.Salary:f2} {res.Email} {res.Age}");
			}

			//var result = employee.GroupBy(p => p.Department, p=>p.Salary).OrderByDescending(s=>s.Average()).First().Key;
			//var outDate = employee.Where(p=>p.Department == result).OrderByDescending(p=>p.Salary).ToList();
			//
			//Console.WriteLine($"Highest Average Salary: {result}");
			//foreach (var item in outDate)
			//{
			//	Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Email} {item.Age}");
			//}
		}
	}
}
