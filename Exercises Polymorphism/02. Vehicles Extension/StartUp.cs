namespace _02.Vehicles_Extension
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class StartUp
	{
		static void Main(string[] args)
		{
			var inputCar = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			double tank = double.Parse(inputCar[1]);
			double litersPerKm = double.Parse(inputCar[2]);
			double tankCapacity = double.Parse(inputCar[3]);
			Vehicles car = new Car(tank, litersPerKm,tankCapacity);

			var inputTruck = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			double tankTrack = double.Parse(inputTruck[1]);
			double literPerKmTrack = double.Parse(inputTruck[2]);
			double tankCapacityTruk = double.Parse(inputTruck[3]);
			Vehicles truck = new Truck(tankTrack, literPerKmTrack,tankCapacity);

			var inputBus = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			double tankBus = double.Parse(inputBus[1]);
			double literPerKmBus = double.Parse(inputBus[2]);
			double tankCapacityBus = double.Parse(inputBus[3]);
			Vehicles bus = new Bus(tankBus, literPerKmBus, tankCapacityBus);

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				try
				{
					var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					if (input[1] == "Car")
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
					else if (input[1] == "Truck")
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
					else
					{
						var data = double.Parse(input[2]);
						switch (input[0])
						{
							case "Drive": bus.Drive(data); break;
							case "Refuel": bus.Refuel(data); break;
							case "DriveEmpty": bus.DriveEmpty(data); break;
							default:
								break;
						}
					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.Message);
				}
				
			}

			Console.WriteLine($"Car: {car.FuelQuantity:f2}");
			Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
			Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");

		}
	}
}
