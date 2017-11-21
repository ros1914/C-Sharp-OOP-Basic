using System;

namespace _09.Rectangle_Intersection
{
	public class Rectangle
	{
		private string id;
		private double width;
		private double height;
		private double  x;
		private double  y;

		public Rectangle(string id , double width , double height , double topLeftHoriz, double topLeftVert)
		{
			this.ID = id;
			this.Width = width;
			this.Height = height;
			this.x = topLeftHoriz;
			this.y = topLeftVert;
		}

		public double Y
		{
			get { return this.y; }
			set { this.y = value; }
		}


		public double X
		{
			get { return this.x; }
			set { this.x = value; }
		}


		public double Height
		{
			get { return this.height; }
			set { this.height = value; }
		}


		public double Width
		{
			get { return this.width; }
			set { this.width = value; }
		}


		public string ID
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public bool RactanglesIsSame(Rectangle second)
		{

			if ((Math.Abs(this.X) <=Math.Abs(second.X + second.Width) && Math.Abs(this.Y) <=Math.Abs(second.Y - second.Height)) && (Math.Abs(this.X + this.Width) >=second.X && Math.Abs(this.Y+ this.Height) >= second.Y))
			{
				return true;
			}
			return false;
		}
	}
}
