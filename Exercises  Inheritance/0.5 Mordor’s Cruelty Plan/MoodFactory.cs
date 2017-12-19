using _0._5_Mordor_s_Cruelty_Plan.MoodModels;

namespace _0._5_Mordor_s_Cruelty_Plan
{
	public class MoodFactory
	{
		public Mood GetMood(int points)
		{
			if (points < -5)
			{
				return new Angry();
			}
			if (points >= -5 && points <= 0)
			{
				return new Sad();
			}
			if (points > 0 && points <= 15)
			{
				return new Happy();
			}


			return new JavaScript();


		}
	}
}
