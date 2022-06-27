using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Список випадково згенерованих нулiв та одиниць:");
            Console.ResetColor();
            Search search = new Search();
            search.ShowList();
            Console.WriteLine();
            search.SearchList();
           
        }
    }
}
