using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._5_Mordor_s_Cruelty_Plan
{
	public class Gandalf
	{
		private List<Food> foodEaten;

		public Gandalf()
		{
			this.foodEaten = new List<Food>();
		}

		public void Eat(Food food)
		{
			this.foodEaten.Add(food);
		}

		public int GetHapinessPoint()
		{
			return foodEaten.Sum(f => f.GetPoints());
		}
	}
}
