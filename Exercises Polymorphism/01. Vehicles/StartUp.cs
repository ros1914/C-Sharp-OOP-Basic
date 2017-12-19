namespace _01.Vehicles
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class StartUp
	{
		static void Main()
		{
			var inputCar = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			
			double tank = double.Parse(inputCar[1]);
			double litersPerKm = double.Parse(inputCar[2]);
			Vehicles car = new Car(tank, litersPerKm);

			var inputTruck = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			double tankTrack = double.Parse(inputTruck[1]);
			double literPerKmTrack = double.Parse(inputTruck[2]);
			Vehicles truck = new Truck(tankTrack,literPerKmTrack);

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				if (input[1]== "Car")
				{
					var data = double.Parse(input[2]);
					switch (input[0])
					{
						case "Drive": car.Drive(data); break;
						case "Refuel": car.Refuel(data); break;
						default:
							break;
					}
				}
				else
				{
					var data = double.Parse(input[2]);
					switch (input[0])
					{
						case "Drive": truck.Drive(data); break;
						case "Refuel": truck.Refuel(data); break;
						default:
							break;
					}
				}
			}

			Console.WriteLine($"Car: {car.FuelQuantity:f2}");
			Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");



		}
	}
}
