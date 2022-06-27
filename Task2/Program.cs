using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вхiдний словник: ");
            Console.ResetColor();
            sort.ShowDictionary();
            sort.SortDictionary();
            sort.SaveToJson();

            



        }

       
    }
}
