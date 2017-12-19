using System;
using System.Collections;

public class RandomList : ArrayList
{

	private Random rnd;

	public RandomList()
	{
		this.rnd = new Random();
	}
	public object RandomString()
	{
		var data = new ArrayList();
		int element = rnd.Next(0, data.Count - 1);
		var str = data[element];
		data.Remove(str);
		return str;
	}
}

