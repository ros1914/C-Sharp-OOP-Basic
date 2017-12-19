namespace _03.WildFarm
{
	using System;
	public class Tiger : Felime
	{
		public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
		{
		}

		//public override void EatFood(Food food)
		//{
		//	var foodType = food.GetType().Name;
		//	if (foodType == "Meat")
		//	{
		//		var data = food.Quantity;
		//		this.FoodEaten = data;
		//	}
		//	else
		//	{
		//		Console.WriteLine($"{this.AnimalType}s are not eating //that type of food!");
		//	}
		//}

		public override void MakeSound()
		{
			Console.WriteLine("ROAAR!!!");
		}

		public override string ToString()
		{
			return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
		}
	}
}
