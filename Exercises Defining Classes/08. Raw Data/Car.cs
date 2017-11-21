namespace _08.Raw_Data
{
	using System.Collections;
	using System.Collections.Generic;

	public class Car
	{
		private string model;
		private Engine engine = new Engine();
		private Cargo cargo = new Cargo();
		private Tire tire = new Tire();
		public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
		{
			this.Model = model;
			this.Engine.EngineSpeed = engineSpeed;
			this.Engine.EnginePower = enginePower;
			this.Cargo.CargoWeight = cargoWeight;
			this.Cargo.CargoType = cargoType;
			this.Tire.Tire1Pressure = tire1Pressure;
			this.Tire.Tire1Age = tire1Age;
			this.Tire.Tire2Pressure = tire2Pressure;
			this.Tire.Tire2Age = tire2Age;
			this.Tire.Tire3Pressure = tire3Pressure;
			this.Tire.Tire3Age = tire3Age;
			this.Tire.Tire4Pressure = tire4Pressure;
			this.Tire.Tire4Age = tire4Age;
		}

		public string Model
		{
			get { return this.model; }
			set { this.model = value; }
		}

		public Engine Engine { get { return this.engine; }  set { this.engine = value; } }
		public Cargo Cargo { get { return this.cargo; } set { this.cargo = value; } }

		public Tire Tire { get { return this.tire; } set { this.tire = value; } }
	}
}
