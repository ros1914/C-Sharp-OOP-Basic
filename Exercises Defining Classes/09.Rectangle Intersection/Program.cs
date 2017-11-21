namespace _09.Rectangle_Intersection
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
			var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = num[0];
			int m = num[1];

			List<Rectangle> rectangle = new List<Rectangle>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				string id = input[0];
				int width = int.Parse(input[1]);
				int height = int.Parse(input[2]);
				int leftCordinates = int.Parse(input[3]);
				int rightCordinates = int.Parse(input[4]);

				Rectangle rect = new Rectangle(id,width,height,leftCordinates,rightCordinates);
				
				rectangle.Add(rect);
			}

			for (int i = 0; i < m; i++)
			{
				var data = Console.ReadLine().Split(' ');

				var first = data[0];
				var second = data[1];

				var firstId = rectangle.First(x=>x.ID == data[0]);
				var secondId = rectangle.Where(x => x.ID == second).First();
				var result = firstId.RactanglesIsSame(secondId);

				if (result == true)
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}
				//RectangelIsSame(firstId,secondId);

			}


		}

		
	}
}
