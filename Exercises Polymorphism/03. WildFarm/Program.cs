namespace _03.WildFarm
{
	using System;
	using System.Collections.Generic;

	public class Program
	{
		static void Main()
		{
			var input = string.Empty;

			while ((input = Console.ReadLine() )!= "End")
			{
				var infoAnimal = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				var infoFood = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				Animal animal = null;
				Food food = null;

				var animalType = infoAnimal[0];
				var animalName = infoAnimal[1];
				var animalWeight = double.Parse(infoAnimal[2]);
				var animalLivingRegion = infoAnimal[3];

				switch (animalType)
				{
					case "Mouse":
						animal = new Mouse(animalType, animalName, animalWeight, animalLivingRegion);
						break;
					case "Cat":
						animal = new Cat(animalType, animalName, animalWeight, animalLivingRegion, infoAnimal[4]);
						break;
					case "Tiger":
						animal = new Tiger(animalType, animalName, animalWeight, animalLivingRegion);
						break;
					case "Zebra":
						animal = new Zebra(animalType, animalName, animalWeight, animalLivingRegion);
						break;
					default:
						break;
				}
				
				switch (infoFood[0])
				{
					case "Vegetable":
						food = new Vegetable(int.Parse(infoFood[1]));
						break;
					case "Meat":
						food = new Vegetable(int.Parse(infoFood[1]));
						break;
					default:
						break;
				}

				animal.MakeSound();
				animal.EatFood(food);
				Console.WriteLine(animal);
			}

			
		}
	}
}
