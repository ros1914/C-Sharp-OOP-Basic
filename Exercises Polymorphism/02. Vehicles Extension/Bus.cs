namespace _02.Vehicles_Extension
{
	using System;
	public class Bus : Vehicles
	{
		public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
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

		public override void Drive(double distance)
		{
			var distanseLiters = distance * (this.LitersPerKm + 1.4);
			if (this.FuelQuantity >= distanseLiters)
			{
				this.FuelQuantity = this.FuelQuantity - distanseLiters;
				Console.WriteLine($"Bus travelled {distance} km");
			}
			else
			{
				Console.WriteLine("Bus needs refueling");
			}
		}

		public override void DriveEmpty(double distance)
		{
			var distanseLiters = distance * this.LitersPerKm ;
			if (this.FuelQuantity >= distanseLiters)
			{
				this.FuelQuantity = this.FuelQuantity - distanseLiters;
				Console.WriteLine($"Bus travelled {distance} km");
			}
			else
			{
				Console.WriteLine("Bus needs refueling");
			}
		}

		public override void Refuel(double liters)
		{
			if (liters <= 0)
			{
				throw new ArgumentException("Fuel must be a positive number");
			}
			else if (this.TankCapacity < this.FuelQuantity + liters)
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
