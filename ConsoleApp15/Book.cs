using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Book:Product
    {
        public string Author;
        public string Genre;

        public Book(string author, string genre, byte price, string relasedate, int count):base(price, relasedate, count)
        {
            Author = author;
            Genre = genre;
        }
        public string Info()
        {
            return $"Author: {Author}, Genre: {Genre}";
        }
        public string Information()
        {
         
            return $"Author: {Author}, Genre: {Genre}, Price: {Price}, Relasedate: {RelaseDate}, Count: {Count} ";
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
            return $"Author: {Author}, Genre: {Genre}, Price: {Price}, Relasedate: {RelaseDate}, Count: {Count} ";
        }
    }
}
