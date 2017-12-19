namespace _01.Class_Box
{
	public class Box
	{
		private double length;
		private double width;
		private double height;

		public Box(double length, double width , double height)
		{
			this.Length = length;
			this.Width = width;
			this.Height = height;
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


		public double Length
		{
			get { return this.length; }
			set { this.length = value; }
		}

		public double SurfaceArea()
		{
			var result = (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
			
			return result;

		}

		public double LateralSurfaceArea()
		{
			var result = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
			return result;
		}

		public double Volume()
		{
			var result = this.Length * this.Width * this.Height;
			return result;
		}
	}
}
