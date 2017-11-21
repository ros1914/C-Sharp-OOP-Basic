namespace _01.Define_a_class_Person
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{

			Type personType = typeof(Person);
			FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
			Console.WriteLine(fields.Length);

			//Person persone = new Person();
			//persone.Name = "Pesho";
			//persone.Age = 20;

		}
	}
}
