namespace _05.Pizza_Calories
{
	using System;
	public class Dough
	{
		private string flourType;
		private string bakingTechnique;
		private int weight;

		public Dough(string flourType, string bakingTechnique, int weight)
		{
			this.FlourType = flourType;
			this.BakingTechnique = bakingTechnique;
			this.Weight = weight;
		}

		public int Weight
		{
			get { return this.weight; }
			private set
			{
				if (value < 1 || value> 200)
				{
					throw new ArgumentException($"Dough weight should be in the range [1..200].");
				}
				this.weight = value;
			}
		}


		public string BakingTechnique
		{
			get { return this.bakingTechnique; }
			private set
			{
				if (value != "Crispy" && value != "Chewy" && value != "Homemade")
				{
					throw new ArgumentException($"Invalid type of dough.");
				}
				this.bakingTechnique = value;
			}
		}


		public string FlourType
		{
			get { return this.flourType; }
			private set
			{
				if (value != "White" && value != "Wholerain")
				{
					throw new ArgumentException($"Invalid type of dough.");
				}
				this.flourType = value;
			}
		}

		public double GetCaloriesOfDough()
		{
			
			double dough = 0.0;
			double baking = 0.0;
			if (this.FlourType == "White")
			{
				dough = 1.5;
			}
			else if (this.FlourType== "Wholerain")
			{
				dough = 1.0;
			}
			 if (this.BakingTechnique == "Crispy")
			{
				baking = 0.9;
			}
			else if (this.BakingTechnique == "Chewy")
			{
				baking = 1.1;
			}
			else if (this.BakingTechnique == "Homemade")
			{
				baking = 1.0;
			}

			var result = (2 * this.Weight) * dough * baking;
			return result;
		}
	}
}
