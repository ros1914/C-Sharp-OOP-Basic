namespace _0._5_Mordor_s_Cruelty_Plan
{
	public abstract class Mood
	{
		public string MoodName { get; set; }

		public Mood(string moodName)
		{
			this.MoodName = moodName;
		}

		public override string ToString()
		{
			return this.MoodName;
		}
	}
}
