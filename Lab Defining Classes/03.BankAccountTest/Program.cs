
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		static void Main()
		{
			var account = new Dictionary<int, BankAccount>();
			string input;
			while ((input = Console.ReadLine()) != "End")
			{
				var comand = input.Split(' ');
				string cmd = comand[0];
				switch (cmd)
				{
					case "Create": Create(comand, account); break;
					case "Deposit": Deposit(comand, account); break;
					case "Withdraw": Withdraw(comand, account); break;
					case "Print": Print(comand,account);break;
					default:
						break;
				}
			}
		}

		private static void Print(string[] comand, Dictionary<int, BankAccount> account)
		{
			int id = int.Parse(comand[1]);
			if (account.ContainsKey(id))
			{
				Console.WriteLine(account[id].ToString());
			}
			else
			{
				Console.WriteLine("Account does not exist");

			}
		}

		private static void Withdraw(string[] comand, Dictionary<int, BankAccount> account)
		{
			int id = int.Parse(comand[1]);
			double balance = double.Parse(comand[2]);
			if (account.ContainsKey(id))
			{
				if (account[id].Balance < balance)
				{
					Console.WriteLine("Insufficient balance");
				}
				else
				{
					account[id].Withdraw(balance);
				}
			}
			else
			{
				Console.WriteLine("Account does not exist");

			}
		}

		private static void Deposit(string[] comand, Dictionary<int, BankAccount> account)
		{
			int id = int.Parse(comand[1]);
			double balance = double.Parse(comand[2]);
			if (account.ContainsKey(id))
			{
				account[id].Deposit(balance);
			}
			else
			{
				Console.WriteLine("Account does not exist");
			}

		}

		private static void Create(string[] comand, Dictionary<int, BankAccount> account)
		{
			int id = int.Parse(comand[1]);
			if (!account.ContainsKey(id))
			{
				BankAccount acc = new BankAccount();
				acc.ID = id;
				account.Add(id, acc);

			}
			else
			{
				Console.WriteLine("Account already exists");
			}
		}
	}

