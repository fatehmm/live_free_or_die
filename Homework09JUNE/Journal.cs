using System;
namespace Homework09JUNE
{
	public class Journal:Product
	{
		public Journal()
		{
		}
		public string Company;
        public override void GetInfo()
        {
            Console.WriteLine($"{Name} -- {Company}");
        }
    }
}

