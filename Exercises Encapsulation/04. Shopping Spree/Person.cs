
namespace _04.Shopping_Spree
{
	using System.Collections.Generic;
	using System;
	public class Person
	{
		private string name;	
		private double money;
		private Product bagOfProducts;

		public Person(string name, double money)
		{
			this.Name = name;
			this.Money = money;
			this.BagOfProducts = new List<Product>();
		}


		public double Money
		{
			get { return this.money; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}
				this.money = value;
			}
		}


		public string Name
		{
			get { return this.name; }
			private set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty");
				}
				this.name = value;
			}
		}

		public ICollection<Product> BagOfProducts { get; set; }

		
	}
}
