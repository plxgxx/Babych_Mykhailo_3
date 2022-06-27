using System;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Task3 task3= new Task3();
            task3.ShowTask();
            Console.WriteLine();
            task3.Whole();
            Console.WriteLine();
            task3.SumOfUnpaired();
        }
    }
}
