namespace _01.Vehicles
{
	public abstract  class Vehicles
	{
		private double fuelQuantity;
		private double litersPerKm;

		public Vehicles(double fuelQuantity, double litersPerKm)
		{
			this.FuelQuantity = fuelQuantity;
			this.LitersPerKm = litersPerKm;
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
	}
}
