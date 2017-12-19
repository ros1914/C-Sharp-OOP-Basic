namespace _03.WildFarm
{
	using System;
	public abstract class Mammal : Animal 
	{
		private string livingRegion;

		public Mammal(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight)
		{
			this.LivingRegion = livingRegion;
		}

		public string LivingRegion
		{
			get { return this.livingRegion; }
			set { this.livingRegion = value; }
		}

		public override void EatFood(Food food)
		{
			string animalType = this.GetType().Name;

			var foodType = food.GetType().Name;

			if ((animalType == "Zebra" || animalType == "Mouse") && foodType != "Vegetable")
			{
				Console.WriteLine($"{animalType}s are not eating that type of food!");
				return;
			}
			if (animalType == "Tiger" && foodType != "Meat")
			{
				Console.WriteLine($"{animalType}s are not eating that type of food!");
				return;
			}
			this.FoodEaten += food.Quantity;
		}

		public override string ToString()
		{
			return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
		}


	}
}
