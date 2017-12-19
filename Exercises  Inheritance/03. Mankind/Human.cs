namespace _03.Mankind
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Human
	{

		private string firstName;
		private string lastName;

		public Human(string firstName , string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public string LastName
		{
			get { return this.lastName; }
			protected set
			{
				
				if (Char.IsLower(value[0]))
				{
					throw new ArgumentException($"Expected upper case letter! Argument: {this.LastName}");
				}
				if (value.Length <= 2)
				{
					throw new ArgumentException($"Expected length at least 4 symbols! Argument: {this.LastName}");
				}
				this.lastName = value;
			}
		}


		public string FirstName
		{
			get { return this.firstName; }
			protected set
			{
				
				if (Char.IsLower(value[0]))
				{
					throw new ArgumentException($"Expected upper case letter! Argument: {this.FirstName}");
				}
				if (value.Length <= 3)
				{
					throw new ArgumentException($"Expected length at least 4 symbols! Argument: {this.FirstName}");
				}
				this.firstName = value;
			}
		}

	}
}
