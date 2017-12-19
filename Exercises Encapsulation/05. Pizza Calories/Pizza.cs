namespace _05.Pizza_Calories
{
	using System.Collections.Generic;
	using System;
	public class Pizza
	{
		private string name;
		private Dough dough;
		private Topping toping;
		private int numberOfToping;
		
		
		public Pizza(string name , Dough dough,IList<Topping> topping, int numberOfToping)
		{
			this.Name = name;
			this.Dough = dough;
			this.Topping = new List<Topping>();
			this.NumberOfToping = numberOfToping;
		}
		public int NumberOfToping
		{
			get { return this.numberOfToping; }
			set
			{
				if (value > 10)
				{
					throw new ArgumentException("Number of toppings should be in range [0..10].");
				}
				this.numberOfToping = value;
			}
		}

		public ICollection<Topping> Topping
		{
			get;
			set;
		}
		public Dough Dough { get; set; }

		public string Name
		{
			get { return this.name; }
			set
			{
				if (string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value) && value.Length > 15 )
				{
					throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
				}
				this.name = value;
			}
		}



	}
}
