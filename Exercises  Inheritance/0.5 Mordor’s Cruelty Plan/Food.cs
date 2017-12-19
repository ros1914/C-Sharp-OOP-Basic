namespace _0._5_Mordor_s_Cruelty_Plan
{
	public abstract class Food 
	{
		private int HappinesPoints { get; set; }

		public Food(int happinesPoints) 
		{
			this.HappinesPoints = happinesPoints;
		}

		public int GetPoints()
		{
			return this.HappinesPoints;
		}
	}
}
