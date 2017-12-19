using _0._5_Mordor_s_Cruelty_Plan.FoodModels;

namespace _0._5_Mordor_s_Cruelty_Plan
{
	

	public class FoodFactory
	{
		public Food GetFood(string foodType)
		{
			switch (foodType.ToLower())
			{
				case "cram": return new Cram();
				case "lembas": return new Lembas();
				case "apple": return new Apple();
				case "melon": return new Melon();
				case "honeycake": return new HoneyCake();
				case "mushrooms": return new Mushrooms();
				default:
					return new EverythingElse();

			}


		}

	}
}
