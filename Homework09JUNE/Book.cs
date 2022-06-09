using System;
namespace Homework09JUNE
{
	public class Book: Product
	{
		public Book()
		{
		}

        public string Author;

        public string Genre;

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} - {Genre}...");
        }
    }
}

