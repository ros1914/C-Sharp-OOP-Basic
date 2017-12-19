using System;
namespace _04.Online_Radio_Database
{
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Collections.Generic;
	
	public class Program
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			List<OnlineRadio> radio = new List<OnlineRadio>();
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(new[] { ';'},StringSplitOptions.RemoveEmptyEntries);
				try
				{
					string artist = input[0];
					string song = input[1];
					try
					{
						List<long> tokensTime = input[2].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
					}
					catch (Exception)
					{

						throw new ArgumentException("Invalid song length.");
					}
					var time = input[2];
					OnlineRadio onlineRadio = new OnlineRadio(artist,song,time);
					radio.Add(onlineRadio);
					Console.WriteLine("Song added.");
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.Message);
				}
			}
			//var times = radio.Select(r => r.SongLength).Sum();
			//var times = new TimeSpan(radio.Select(r=>r.SongLength));
			List<TimeSpan> times = new List<TimeSpan>();
			foreach (var item in radio.Select(r=>r.SongLength))
			{
				var data = item.Split(':');
				var  result = new TimeSpan(0,int.Parse(data[0]),int.Parse(data[1]));
				times.Add(result);
			}
			var outResult = times.Select(r=>r.Hours);
			var total = new TimeSpan(times.Sum(r => r.Ticks));

			Console.WriteLine($"Songs added: {radio.Count()}");
			Console.WriteLine($"Playlist length: {total.Hours}h {total.Minutes}m {total.Seconds}s");
		}
	}
}
