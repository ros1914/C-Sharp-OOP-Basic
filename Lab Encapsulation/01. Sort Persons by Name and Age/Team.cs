using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Team
{
	private string name;
	private List<Person> firstTeam;
	private List<Person> reserveTeam;

	public Team(string name)
	{
		this.Name = name;
		this.firstTeam = new List<Person>();
		this.reserveTeam = new List<Person>();
	}

	public string Name
	{
		get { return this.name; }
		set { this.name = value; }
	}

	public IReadOnlyCollection<Person> FirstTeam { get { return this.firstTeam.AsReadOnly(); }  }
	public IReadOnlyCollection<Person> ReserveTeam { get { return this.firstTeam.AsReadOnly(); } }

	public void AddPlayer(Person plyer)
	{
		if (plyer.Age < 40)
		{
			firstTeam.Add(plyer);
		}
		else
		{
			reserveTeam.Add(plyer);
		}

	}

	public override string ToString()
	{
		return $"First team have {this.firstTeam.Count} players\nReserve team have {this.reserveTeam.Count} players";
	}


}

