using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Product
    {
        public byte Price;
        public string RelaseDate;
        public int Count;

        public Product(byte price, string relasedate, int count)
        {
            Price = price;
            RelaseDate = relasedate;
            Count = count;
        }

        public string Info()
        {
            return $"Price: {Price}, RelaseDate: {RelaseDate}, Count: {Count}";
        }

    }
}
