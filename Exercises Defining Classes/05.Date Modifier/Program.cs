namespace _05.Date_Modifier
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			var firstDate = DateTime.Parse(Console.ReadLine());
			var secondDate = DateTime.Parse(Console.ReadLine());

			DateModifier time = new DateModifier(firstDate,secondDate);

			Console.WriteLine(time.GetDifferenceBetweenTwoDates(time));

		}
	}
}
