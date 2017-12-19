namespace _01.Vehicles
{
	using System;

	public class Truck : Vehicles
	{
		public Truck(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
		{
		}

		public override double LitersPerKm
		{
			
			set
			{
				value = value + 1.6;
				base.LitersPerKm = value;
			}
		}

		public override double FuelQuantity
		{
			
			set
			{
				//value = value / 1.05;
				base.FuelQuantity = value;
			}
		}
		public override void Drive(double distance)
		{
			var distanseLiters = distance * this.LitersPerKm;
			if (FuelQuantity >= distanseLiters)
			{
				this.FuelQuantity = this.FuelQuantity - distanseLiters;
				Console.WriteLine($"Truck travelled {distance} km");
			}
			else
			{
				Console.WriteLine("Truck needs refueling");
			}
		}

		public override void Refuel(double liters)
		{
			this.FuelQuantity =this. FuelQuantity + (liters*0.95);
		}
	}
}
