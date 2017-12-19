namespace _04.Online_Radio_Database
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class OnlineRadio
	{
		private string artistName;
		private string songName;
		private string songLength;

		public OnlineRadio(string artistName, string songName, string songLength)
		{
			this.ArtistName = artistName;
			this.SongName = songName;
			this.SongLength = songLength;
		}

		public string SongLength
		{
			get { return this.songLength; }
			protected set
			{
				var data = value.Split(':');
				int minuti = int.Parse(data[0]);
				int secundi = int.Parse(data[1]);
				if (minuti > 14 )
				{
					throw new ArgumentException("Song minutes should be between 0 and 14.");
				}
				if (secundi > 59)
				{
					throw new ArgumentException("Song seconds should be between 0 and 59.");
				}
				this.songLength = value;
			}
		}
		
		public string SongName
		{
			get { return this.songName; }
			protected set
			{
				if (value.Length < 3 || value.Length > 20)
				{
					throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
				}
				this.songName = value;
			}
		}


		public string ArtistName
		{
			get { return this.artistName; }
			protected set
			{
				if (value.Length < 3 || value.Length > 20)
				{
					throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
				}
				this.artistName = value;
			}
		}

	}
}
