﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	static void Main()
	{
		Dog dog = new Dog();

		dog.Eat();
		dog.Bark();

		Cat cat = new Cat();

		cat.Eat();
		cat.Meow();
	}
}

