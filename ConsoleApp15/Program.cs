                      using System;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Islam Khalitov", "Detective", 15, "01.11.2022", 1000);
            Console.WriteLine(book.Info());
            Console.WriteLine(book.Information());
            Console.WriteLine(book.Sell());




            NewsPaper newsPaper = new NewsPaper("Coca Cola", "Drink", 5, "11.10.2022", 1000);
            Console.WriteLine(newsPaper.Info());
            Console.WriteLine(newsPaper.Information());
            Console.WriteLine(newsPaper.Sell());
        }
    }
}
