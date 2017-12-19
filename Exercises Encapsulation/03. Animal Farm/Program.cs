namespace _03.Animal_Farm
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
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			try
			{
				Chicken chicken = new Chicken(name, age);

				chicken.CalculateProductPerDay();
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			
		}
	}
}
