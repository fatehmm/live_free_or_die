using System;
namespace Homework09JUNE
{
	public class Library
	{
		public Library()
		{
		}
		public Product[] Products = new Product[0];

		public void AddProduct(Product product)
        {
			Array.Resize(ref Products, Products.Length + 1);
			Products[Products.Length - 1] = product;
        }

		public int GetJournalCount()
        {
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Journal)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetBooksCount()
        {
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Book)
                {
                    count++;
                }
            }
            return count;
        }

        public Product[] GetProducts(bool isBook)
        {
            Product[] resultProducts = new Product[0];
            if (isBook == true)
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i] is Book)
                    {
                        Array.Resize(ref resultProducts, resultProducts.Length + 1);
                        resultProducts[resultProducts.Length - 1] = Products[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i] is Journal)
                    {
                        Array.Resize(ref resultProducts, resultProducts.Length + 1);
                        resultProducts[resultProducts.Length - 1] = Products[i];
                    }
                }
            }
            return resultProducts;
        }

        public int ProductLimit = 15;

    }
}

