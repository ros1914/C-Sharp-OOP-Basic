namespace _08.Raw_Data
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
			List<Car> cars = new List<Car>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				string model = input[0];
				int engineSpeed = int.Parse(input[1]);
				int enginePower = int.Parse(input[2]);
				int cargoWeight = int.Parse(input[3]);
				string cargoType = input[4];
				double tire1 = double.Parse(input[5]);
				int tire1Age = int.Parse(input[6]);
				double tire2 = double.Parse(input[7]);
				int tire2Age = int.Parse(input[8]);
				double tire3 = double.Parse(input[9]);
				int tire3Age = int.Parse(input[10]);
				double tire4 = double.Parse(input[11]);
				int tire4Age = int.Parse(input[12]);

				var rawDate = new Car(model, enginePower,engineSpeed,  cargoWeight, cargoType, tire1, tire1Age, tire2, tire2Age, tire3, tire3Age, tire4, tire4Age);
				cars.Add(rawDate);
			}

			string comand = Console.ReadLine();

			if (comand == "fragile")
			{
				var result = cars.Where(k => k.Cargo.CargoType == "fragile" && (k.Tire.Tire1Pressure < 1 ||
					k.Tire.Tire2Pressure < 1 ||
					k.Tire.Tire3Pressure < 1 ||
					k.Tire.Tire4Pressure < 1));

				foreach (var item in result)
				{
					Console.WriteLine(item.Model);
				}
			}
			else
			{
				var result = cars.Where(X => X.Engine.EnginePower > 250);
				foreach (var item in result)
				{
					Console.WriteLine(item.Model);
				}
			}
		}
	}
}
