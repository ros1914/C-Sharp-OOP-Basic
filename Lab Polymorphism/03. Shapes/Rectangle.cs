﻿public class Rectangle : Shape
{
	private double height;
	private double width;

	public Rectangle(double height , double width) 
	{
		this.Height = height;
		this.Width = width; 
	}

	public double Width
	{
		get { return this.width; }
		set { this.width = value; }
	}


	public double Height
	{
		get { return this.height; }
		set { this.height = value; }
	}

	public override double CalculateArea()
	{
		return this.Width * this.Height;
	}

	public override double CalculatePerimeter()
	{
		return (this.Height * 2) + (2 * this.Width);

	}

	public override string Draw()
	{
		return base.Draw() + "Rectangle";
	}
}

