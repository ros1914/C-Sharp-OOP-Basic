namespace _01.Define_a_class_Person
{
	public class Person
	{
		public string name;
		public int age;
		//public Person( string name, int age)
		//{
		//	this.Name = name;
		//	this.Age = age;
		//}

		public int Age
		{
			get { return this.age; }
			set { this.age = value; }
		}


		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

	}
}
