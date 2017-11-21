using System.Text;

namespace _10.Car_Salesman
{
	public class Car
	{
		private string model;
		private Engine engine;
		private string weight;
		private string color;

		public Car(string model , Engine engine )
		{
			this.Model = model;
			this.Engine = engine;
			this.Weight = "n/a";
			this.Color = "n/a";
		}

		public string Color
		{
			get { return this.color; }
			set { this.color = value; }
		}


		public string Weight
		{
			get { return this.weight; }
			set { this.weight = value; }
		}


		public Engine Engine
		{
			get { return this.engine; }
			set { this.engine = value; }
		}


		public string Model
		{
			get { return this.model; }
			set { this.model = value; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"{this.Model}:");
			sb.AppendLine( $" {this.Engine.Model}:");
			sb.AppendLine(  $"  Power: {this.Engine.Power}");
			sb.AppendLine(  $"  Displacement: {this.Engine.Displacement}");
			sb.AppendLine(  $"  Efficiency: {this.Engine.Efficiency}");
			sb.AppendLine( $" Weight: {this.Weight}");
			sb.AppendLine( $" Color: {this.Color}");
			return sb.ToString();
		}
	}
}
