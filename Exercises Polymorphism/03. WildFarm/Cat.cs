namespace _03.WildFarm
{
	using System;
	public class Cat : Felime
	{
		private string breed;

		public Cat(string animalType, string animalName, double animalWeight, string livingRegion,string breed) : base(animalType, animalName, animalWeight, livingRegion)
		{
			this.Breed = breed;
		}

		public string Breed
		{
			get { return this.breed; }
			set { this.breed = value; }
		}

		//public override void EatFood(Food food)
		//{
		//	var data = food.Quantity;
		//	this.FoodEaten = data;
		//}

		public override void MakeSound()
		{
			Console.WriteLine("Meowwww");
		}

		public override string ToString()
		{
			return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
		}

	}
}
