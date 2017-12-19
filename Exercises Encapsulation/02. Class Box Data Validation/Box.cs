﻿namespace _02.Class_Box_Data_Validation
{
	using System;
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
			set
			{
				if (value < 0 || value ==0)
				{
					throw new ArgumentException("Height cannot be zero or negative. ");
				}
				this.height = value;
			}
		}


		public double Width
		{
			get { return this.width; }
			set
			{
				if (value < 0 || value == 0)
				{
					throw new ArgumentException("Width cannot be zero or negative. ");
				}
				this.width = value;
			}
		}


		public double Length
		{
			get { return this.length; }
			set
			{
				if (value < 0 || value == 0)
				{
					throw new ArgumentException("Length cannot be zero or negative. ");
				}
				this.length = value;
			}
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
