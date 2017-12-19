

namespace _03.Mankind
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
			try
			{
				var inputStudent = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				string studentFirstName = inputStudent[0];
				string studentLastName = inputStudent[1];
				string facultyNumber = inputStudent[2];

				var inputWorker = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string workerFirstName = inputWorker[0];
				string workerLastName = inputWorker[1];
				double salary = double.Parse(inputWorker[2]);
				double working = double.Parse(inputWorker[3]);

				Student st = new Student(studentFirstName, studentLastName, facultyNumber);
				Worker worker = new Worker(workerFirstName, workerLastName, salary, working);

				Console.WriteLine(st.ToString());
				Console.WriteLine(worker.ToString());
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			
		}
	}
}
