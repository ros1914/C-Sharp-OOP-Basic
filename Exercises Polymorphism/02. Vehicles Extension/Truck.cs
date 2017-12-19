namespace _02.Vehicles_Extension
{
	using System;

	public class Truck : Vehicles
	{
		public Truck(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
		{
		}

		public override double TankCapacity
		{
			get => base.TankCapacity;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Fuel must be a positive number");
				}
				base.TankCapacity = value;
			}
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
			if (this.FuelQuantity >= distanseLiters)
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
			if (liters <= 0)
			{
				throw new ArgumentException("Fuel must be a positive number");
			}
			else if (this.TankCapacity < this.FuelQuantity + (liters * 0.95))
			{
				throw new ArgumentException("Cannot fit fuel in tank");
			}
			else
			{
				this.FuelQuantity = this.FuelQuantity + liters;

			}
			
		}
	}
}
