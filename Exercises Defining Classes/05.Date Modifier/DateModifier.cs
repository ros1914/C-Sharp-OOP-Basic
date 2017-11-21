using System;

namespace _05.Date_Modifier
{
	public class DateModifier
	{
		private DateTime dateTimeFirst;
		private DateTime dateTimeSecond;

		public DateModifier(DateTime dateTimeFirst,DateTime dateTimeSecond)
		{
			this.DateTimeFirst = dateTimeFirst;
			this.DateTimeSecond = dateTimeSecond;
		}

		public DateTime DateTimeSecond
		{
			get { return this.dateTimeSecond; }
			set { this.dateTimeSecond = value; }
		}


		public DateTime DateTimeFirst
		{
			get { return this.dateTimeFirst; }
			set { this.dateTimeFirst = value; }
		}

		public int GetDifferenceBetweenTwoDates(DateModifier time)
		{
			TimeSpan interval = time.dateTimeFirst - time.dateTimeSecond;

			return Math.Abs(interval.Days);
		}
	}
}
