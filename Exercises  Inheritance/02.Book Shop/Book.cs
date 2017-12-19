namespace _02.Book_Shop
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Book
	{
		
		public string title;
		public string author;
		public decimal price;

		public Book(string author,  string title, decimal price)
		{
			
			this.Title = title;
			this.Author = author;
			this.Price = price;
		}

		public virtual decimal Price
		{
			get { return this.price; }
			protected set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Author not valid!");
				}
				this.price = value;
			}
		}


		public string Author
		{
			get { return this.author; }
			protected set
			{
				var data = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				if (data.Length > 1)
				{
					if (char.IsDigit(data[1][0]))
					{
						throw new ArgumentException("Author not valid!");
					}
				}
				this.author = value;
			}
		}


		public string Title
		{
			get { return this.title; }
			protected set
			{
				if (value.Length <= 3)
				{
					throw new ArgumentException("Title not valid!");
				}
				this.title = value;
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Type: ").AppendLine(this.GetType().Name)
				.Append("Title: ").AppendLine(this.Title)
				.Append("Author: ").AppendLine(this.Author)
				.Append("Price: ").Append($"{this.Price:f1}")
				.AppendLine();
			
			return stringBuilder.ToString();
		}
	}
}
