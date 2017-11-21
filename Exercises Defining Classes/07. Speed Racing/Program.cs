namespace _07.Speed_Racing
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
			List<Car> car = new List<Car>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				string model = input[0];
				double fuelAmount = double.Parse(input[1]);
				double fuelForKilomenter = double.Parse(input[2]);
				Car speedCars = new Car(model, fuelAmount, fuelForKilomenter);

				if (!car.Any(l => l.Model == model))
				{
					car.Add(speedCars);
					

				}
			}

			string comand;
			while ((comand = Console.ReadLine()) != "End")
			{
				var cmd = comand.Split(' ');
				string model = cmd[1];
				double distance = double.Parse(cmd[2]);

				var koli = car.First(k=>k.Model == model);
				koli.Drive(model, distance);
			}

			foreach (var item in car)
			{
				Console.WriteLine($"{item.Model} {item.FullAmount:f2} {item.DistanceTraveled}");
			}
		}
	}
}
