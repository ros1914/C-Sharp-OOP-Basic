﻿namespace _03.WildFarm
{
	using System;
	public class Zebra : Mammal
	{
		public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
		{
		}

		//public override void EatFood(Food food)
		//{
		//	var foodType = food.GetType().Name;
		//	if (foodType == "Vegetable")
		//	{
		//		var data = food.Quantity;
		//		this.FoodEaten = data;
		//	}
		//	else
		//	{
		//		Console.WriteLine($"{this.AnimalType}are not eating /that/ type of food!");
		//	}
		//}

		public override void MakeSound()
		{
			Console.WriteLine("Zs");
		}

		//public override string ToString()
		//{
		//	return $"{this.AnimalType}[{this.AnimalName}, //{this.AnimalWeight}, {this.LivingRegion}, /{this.FoodEaten}]";
		//}
	}
}
