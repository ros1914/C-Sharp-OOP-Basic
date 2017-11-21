namespace _10.Car_Salesman
{
	public class Engine
	{
		private string model;
		private int power;
		private string displacement;
		private string efficiency;

		public Engine(string model , int power)
		{
			this.Model = model;
			this.Power = power;
			this.Displacement = "n/a";
			this.Efficiency = "n/a";
		}

		public string Efficiency
		{
			get { return this.efficiency; }
			set { this.efficiency = value; }
		}


		public string Displacement
		{
			get { return this.displacement; }
			set { this.displacement = value; }
		}


		public int Power
		{
			get { return this.power; }
			set { this.power = value; }
		}


		public string Model
		{
			get { return this.model; }
			set { this.model = value; }
		}

	}
}
