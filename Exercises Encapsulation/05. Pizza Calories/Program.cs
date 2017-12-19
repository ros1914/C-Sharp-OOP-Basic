namespace _05.Pizza_Calories
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var input = Console.ReadLine().Split(' ');
				List<Topping> listToping = new List<Topping>();
				int n = int.Parse(input[2]);
				if (n > 10)
				{
					//Pizza calcone = new Pizza(input[0],);
				}
				string namePizza = input[1];
				while (input[0] != "END")
				{

					input = Console.ReadLine().Split(' ');
					string dought = input[1];
					var baking = input[2].ToCharArray();
					var resultBaking = "";
					for (int i = 0; i < baking.Length; i++)
					{
						if (i == 0)
						{
							resultBaking += baking[i].ToString().ToUpper();
						}
						else
						{
							resultBaking += baking[i].ToString().ToLower();
						}
					}


					int weightDough = int.Parse(input[3]);

					Dough dough = new Dough(dought, resultBaking, weightDough);
					
					var caloriyTopping = 0.0;
					for (int i = 0; i < n; i++)
					{
						var data = Console.ReadLine().Split(' ');
						var type = data[1].ToCharArray();

						var resultType = "";
						for (int s = 0; s < type.Length; s++)
						{
							if (s == 0)
							{
								resultType += type[s].ToString().ToUpper();
							}
							else
							{
								resultType += type[s].ToString().ToLower();
							}
						}

						double weight = double.Parse(data[2]);
						Topping topping = new Topping(resultType, weight);
						caloriyTopping += topping.GetCaloriesOfToping();
						listToping.Add(topping);
						
					}
					Pizza pizza = new Pizza(namePizza, dough, listToping, n);
					var caloryDough = pizza.Dough.GetCaloriesOfDough();
					
					Console.WriteLine($"{pizza.Name} - {caloriyTopping + caloryDough:f2} Calories.");
					input = Console.ReadLine().Split(' ');


				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
	}
}
