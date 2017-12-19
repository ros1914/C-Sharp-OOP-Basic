namespace _05.Pizza_Calories
{
	using System;
	public class Topping
	{

		private string typeOfToping;

		private double weight;

		public Topping(string typeOfToping, double weight)
		{
			this.TypeOfToping = typeOfToping;
			this.Weight = weight;

		}
		public string TypeOfToping
		{
			get { return this.typeOfToping; }
			set
			{

				if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
				{
					throw new ArgumentException($"Cannot place {value} on top of your pizza.");
				}
				this.typeOfToping = value;
			}
		}

		public double Weight
		{
			get { return this.weight; }
			private set
			{
				if (value < 1 || value > 50)
				{
					throw new ArgumentException($"{this.TypeOfToping} weight should be in the range [1..50].");
				}
				this.weight = value;
			}
		}

		public double GetCaloriesOfToping()
		{
			var result = 0.0;
			if (this.TypeOfToping == "Meat")
			{
				result = 1.2;
			}
			else if (this.TypeOfToping == "Veggies")
			{
				result = 0.8;
			}
			else if (this.TypeOfToping == "Cheese")
			{
				result = 1.1;
			}
			else if (this.TypeOfToping == "Sauce")
			{
				result = 0.9;
			}
			return (2 * result) * this.Weight;
		}
	}
}
