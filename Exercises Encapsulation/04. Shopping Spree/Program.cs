using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shopping_Spree
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Person> persons = new List<Person>();
			List<Product> products = new List<Product>();
			try
			{
				var inputPerson = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
				var inputProduct = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

				for (int i = 0; i < inputPerson.Length; i++)
				{

					var data = inputPerson[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
					string name = data[0];
					double mony = double.Parse(data[1]);
					Person person = new Person(name, mony);
					persons.Add(person);
				}

				for (int i = 0; i < inputProduct.Length; i++)
				{

					var data = inputProduct[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
					//string name = data[0];
					//double cost = double.Parse(data[1]);

					products.Add(new Product(data[0], double.Parse(data[1])));

				}
				string input;

				while ((input = Console.ReadLine()) != "END")
				{
					var data = input.Split(' ');
					string name = data[0];
					string product = data[1];

					var getPersone = persons.Where(x => x.Name == name).First();
					var getProduct = products.Where(x => x.Name == product).First();

					if (getPersone.Money - getProduct.Cost >= 0)
					{
						getPersone.BagOfProducts.Add(getProduct);
						getPersone.Money -= getProduct.Cost;
						Console.WriteLine($"{getPersone.Name} bought {getProduct.Name}");
					}
					else
					{
						Console.WriteLine($"{getPersone.Name} can't afford {getProduct.Name}");
					}
				}

				foreach (var item in persons)
				{
					//var reseult = item.BagOfProducts.Count == 0;
					if (item.BagOfProducts.Count > 0)
					{
						Console.Write($"{item.Name} - ");
						var count = item.BagOfProducts.Count;
						foreach (var i in item.BagOfProducts)
						{
							if (count == 1)
							{
								Console.WriteLine($"{i.Name}");
							}
							else
							{
								Console.Write($"{i.Name}, ");
								count--;
							}
						}

					}
					else
					{
						Console.WriteLine($"{item.Name} - Nothing bought");

					}
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

		}



	}
}


