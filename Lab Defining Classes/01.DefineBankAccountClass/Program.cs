using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
	static void Main(string[] args)
	{
		BankAccount acc = new BankAccount();

		acc.ID = 1;
		//acc.Balance = 15;
		acc.Deposit(15);
		acc.Withdraw(5);

		//Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
		Console.WriteLine(acc.ToString());
	}
}

