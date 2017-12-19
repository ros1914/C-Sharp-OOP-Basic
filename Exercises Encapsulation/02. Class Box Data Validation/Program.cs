namespace _02.Class_Box_Data_Validation
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
			Type boxType = typeof(Box);
			FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine(fields.Count());
			try
			{
				double lenght = double.Parse(Console.ReadLine());
				double width = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());

				Box box = new Box(lenght, width, height);

				Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
				Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
				Console.WriteLine($"Volume - {box.Volume():f2}");
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			


			
		}
	}
}
