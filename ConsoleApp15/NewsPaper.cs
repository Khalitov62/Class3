using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class NewsPaper:Product
    {
        public string Advertisement;
        public string Article;

        public NewsPaper(string advertisement, string article, byte price, string relasedate, int count):base(price, relasedate, count)
        {
            Advertisement = advertisement;
            Article = article; 
        }
        public string Info()
        {
            return $"Advertisement: {Advertisement}, Article: {Article}";
        }
        public string Information()
        {
            return $"Advertisement: {Advertisement}, Article: {Article}, Price: {Price}, Relasedate: {RelaseDate}, Count: {Count}";
        }
        public string Sell()
        {
            if (Count >= 1)
            {
                Count--;
            }
            else
            {
                Console.WriteLine("Satis prossesi heyata kecmedi");
            }
            return $"Advertisement: {Advertisement}, Article: {Article}, Price: {Price}, Relasedate: {RelaseDate}, Count: {Count} ";
        }
    }
}
