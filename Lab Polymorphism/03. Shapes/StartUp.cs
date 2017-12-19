using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
	static void Main()
	{
		Shape circul = new Circle(5);

		Console.WriteLine(circul.CalculateArea());
		Console.WriteLine(circul.CalculatePerimeter());
 	 }
}

