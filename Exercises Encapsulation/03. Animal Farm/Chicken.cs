namespace _03.Animal_Farm
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Chicken
	{

		private string name;
		private int age;

		public Chicken(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public int Age
		{
			get { return this.age; }
			protected set
			{
				if (value < 0 || value > 15)
				{
					throw new ArgumentException("Age should be between 0 and 15.");
				}
				this.age = value;
			}
		}


		public string Name
		{
			get { return this.name; }
			protected set
			{
				if (value == null || value == " " || value=="")
				{
					throw new ArgumentException("Name cannot be empty.");
				}
				this.name = value;
			}
		}


		public void CalculateProductPerDay()
		{
			Console.WriteLine($"Chicken {this.Name} (age {this.Age}) can produce {ProductPerDay()} eggs per day.");
		}
		private double ProductPerDay()
		{
			var result = 0.75;
			if (this.Age <4)
			{
				result = 1.5;
			}
			else if(this.Age > 3 && this.Age<8)
			{
				result = 2;
			}
			else
			{
				result = 1;
			}

			return result; 
		}

	}
}
