using System.Collections.Generic;
using System.Linq;

public class Person
{
	private string name;
	private int age;
	private List<BankAccount> account;
	public Person(string name , int age )
	{
		this.Name = name;
		this.Age = age;
		this.Account = new List<BankAccount>();

	}
	public Person(string name, int age, List<BankAccount> account)
	{
		this.Name = name;
		this.Age = age;
		this.Account = account;
	}

	public List<BankAccount> Account
	{
		get { return this.account; }
		set { this.account = value; }
	}

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

	public double GetBalance()
	{
		return this.account.Sum(a => a.Balance); 
	}

}

