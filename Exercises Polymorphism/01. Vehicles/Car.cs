namespace _01.Vehicles
{
	using System;
	public class Car : Vehicles
	{
		public Car(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
		{

		}

		public override double LitersPerKm
		{
			
			set
			{
				value = value + 0.9;
				base.LitersPerKm = value;
			}
		}
		public override void Drive(double distance)
		{
			var distanseLiters = distance * this.LitersPerKm;
			if (FuelQuantity >= distanseLiters)
			{
				this.FuelQuantity = this.FuelQuantity - distanseLiters;
				Console.WriteLine($"Car travelled {distance} km");
			}
			else
			{
				Console.WriteLine("Car needs refueling");
			}
		}

		public override void Refuel(double liters)
		{
			this.FuelQuantity = this.FuelQuantity + liters;
		}
	}
}
