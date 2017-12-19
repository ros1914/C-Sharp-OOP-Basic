using System.Text;
using System;
using System.Text.RegularExpressions;

namespace _03.Mankind
{
	public class Student : Human
	{

		private string facultyNumber;

		public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
		{
			this.FacultyNumber = facultyNumber;
		}

		public string FacultyNumber
		{
			get { return this.facultyNumber; }
			protected set
			{
				Regex rgx = new Regex(@"^[a-zA-Z0-9]{5,10}$");
				if (!rgx.IsMatch(value))
				{
					throw new ArgumentException("Invalid faculty number!");
				}
				this.facultyNumber = value;
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"First Name: {this.FirstName}")
				.AppendLine($"Last Name: {this.LastName}")
				.Append($"Faculty number: {this.FacultyNumber}");
				
			return sb.ToString();

		}

	}
}
