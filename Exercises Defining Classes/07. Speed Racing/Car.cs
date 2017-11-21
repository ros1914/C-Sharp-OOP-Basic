using System;

namespace _07.Speed_Racing
{
	public class Car
	{
		private string model;
		private double fullAmount;
		private double fuelConsumptionForKilometer;
		private double distaceTraveled = 0;

		public Car(string model, double fullAmount, double fuelConsumptionForKilometer)
		{
			this.Model = model;
			this.FullAmount = fullAmount;
			this.FuelConsumptionForKilometer = fuelConsumptionForKilometer;
		}
		public double DistanceTraveled
		{
			get { return this.distaceTraveled; }
			set { this.distaceTraveled = value; }
		}
		
		public double FuelConsumptionForKilometer
		{
			get { return this.fuelConsumptionForKilometer; }
			set { this.fuelConsumptionForKilometer = value; }
		}

		public double FullAmount
		{
			get { return this.fullAmount; }
			set { this.fullAmount = value; }
		}


		public string Model
		{
			get { return this.model; }
			set { this.model = value; }
		}

		public void Drive(string model ,  double distace)
		{
			var distanceOFModel = this.fullAmount / this.fuelConsumptionForKilometer;
			
			if (distace > distanceOFModel)
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
			else
			{
				this.fullAmount = (distanceOFModel - distace) * this.fuelConsumptionForKilometer;
				this.distaceTraveled += distace;
			}
		}
	}
}
