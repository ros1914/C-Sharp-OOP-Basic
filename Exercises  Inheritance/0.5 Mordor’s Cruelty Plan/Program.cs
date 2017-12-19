namespace _0._5_Mordor_s_Cruelty_Plan
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			var fooffactory = new FoodFactory();
			var moodFactory = new MoodFactory();
			var gandalf = new Gandalf();
			var input = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var ip in input)
			{
				Food food = fooffactory.GetFood(ip);
				gandalf.Eat(food);
			}

			var totalPoints = gandalf.GetHapinessPoint();
			Mood curMood = moodFactory.GetMood(totalPoints);

			Console.WriteLine(totalPoints);
			Console.WriteLine(curMood);
		}
	}
}
