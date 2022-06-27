using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Task3
    {
        public List<int> l = new List<int>();

        public Task3()
        {
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                l.Add(random.Next(-10, 10));
            }
        }

        public void ShowTask()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Список випадково згенерованих чисел: ");
            Console.ResetColor();
            foreach (var item in l)
            {
                Console.Write(item+"  ");
            }
        }
         
        public void Whole()
        {
            var whole = from item in l
                        where item > 0
                        select item;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Список додатнiх чисел: ");
            Console.ResetColor();

            foreach (var item in whole)
            {
                Console.Write(item + "  ");
            }
        }

        public void SumOfUnpaired()
        {
            var sumscollection = from item in l
                                 where item % 2 != 0
                                 select item;
            int sum = sumscollection.Sum();
                      
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сума непарних елементiв: ");
            Console.ResetColor();
            Console.WriteLine(sum);
        }
    }
}
