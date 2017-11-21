namespace _10.Car_Salesman
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

			List<Engine> engine = new List<Engine>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				string model = input[0];
				int power = int.Parse(input[1]);

				Engine engines = new Engine(model, power);
				if (input.Length > 2)
				{
					int number;
					bool result = int.TryParse(input[2], out number);
					if (result)
					{
						engines.Displacement = input[2];
					}
					else
					{
						engines.Efficiency = input[2];
					}
				}
				if (input.Length > 3)
				{
					engines.Efficiency = input[3];
				}

				engine.Add(engines);



			}

			int m = int.Parse(Console.ReadLine());
			List<Car> car = new List<Car>();
			for (int i = 0; i < m; i++)
			{
				var input = Console.ReadLine().Split(' ');
				string model = input[0];
				var carEngine = engine.FirstOrDefault(x=>x.Model== input[1]);

				Car cars = new Car(model, carEngine);
				if (input.Length > 2)
				{
					int number;
					bool result = int.TryParse(input[2], out number);
					if (result)
					{
						cars.Weight = input[2];
					}
					else
					{
						cars.Color = input[2];
					}
				}
				if (input.Length > 3)
				{
					cars.Color = input[3];
				}

				car.Add(cars);
			}

			foreach (var item in car)
			{
				Console.WriteLine(item.ToString());

			}
		}
	}
}
