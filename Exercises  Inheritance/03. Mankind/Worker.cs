using System.Text;
using System;
namespace _03.Mankind
{
	public class Worker : Human
	{
		private double weekSalary;
		private double workHoursPerDay;

		public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHoursPerDay;
		}

		public double WorkHoursPerDay
		{
			get { return this.workHoursPerDay; }
			protected set
			{
				if (value < 1 || value > 12)
				{
					throw new ArgumentException($"Expected value mismatch! Argument: {this.WorkHoursPerDay}");
				}
				this.workHoursPerDay = value;
			}
		}


		public double WeekSalary
		{
			get { return this.weekSalary; }
			protected set
			{
				if (value < 10)
				{
					throw new ArgumentException($"Expected value mismatch! Argument: {this.WeekSalary}");
				}
				this.weekSalary = value;
			}
		}

		public override string ToString()
		{
			var salaryPerHouer = this.WeekSalary / (this.WorkHoursPerDay * 5);
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"First Name: {this.FirstName}")
				.AppendLine($"Last Name: {this.LastName}")
				.AppendLine($"Week Salary: {this.WeekSalary:f2}")
				.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
				.Append($"Salary per houer: {salaryPerHouer:f2}");
			return sb.ToString();
		}
	}
}
