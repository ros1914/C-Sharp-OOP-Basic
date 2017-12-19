namespace _02.Vehicles_Extension
{
	using System;
	public abstract  class Vehicles
	{
		private double fuelQuantity;
		private double litersPerKm;
		private double tankCapacity ;

		public virtual double TankCapacity 
		{
			get { return this.tankCapacity ; }
			set
			{
				//if (value <= 0)
				//{
				//	throw new ArgumentException("Fuel must be a positive //number");
				//}
				this.tankCapacity  = value;
			}
		}
	


		public Vehicles(double fuelQuantity, double litersPerKm , double tankCapacity)
		{
			this.FuelQuantity = fuelQuantity;
			this.LitersPerKm = litersPerKm;
			this.TankCapacity = tankCapacity;
		}

		public virtual double LitersPerKm
		{
			get { return this.litersPerKm; }
			set { this.litersPerKm = value; }
		}


		public virtual double FuelQuantity
		{
			get { return this.fuelQuantity; }
			set { this.fuelQuantity = value; }
		}

		public abstract void Drive(double distance);
		public abstract void Refuel(double liters);
		public virtual void DriveEmpty(double distance) { }
	}
}
