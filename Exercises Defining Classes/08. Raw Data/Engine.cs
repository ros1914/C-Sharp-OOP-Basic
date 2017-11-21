namespace _08.Raw_Data
{
	public class Engine
	{
		private int engineSpeed;
		private int enginePower;

		//public Engine(int engineSpeed , int enginePower)
		//{
		//	this.EnginePower = enginePower;
		//	this.EngineSpeed = engineSpeed;
		//}

		public int EnginePower
		{
			get { return this.enginePower; }
			set { this.enginePower = value; }
		}


		public int EngineSpeed
		{
			get { return this.engineSpeed; }
			set { this.engineSpeed = value; }
		}

	}
}
