using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Search
    {
        List<int> search = new List<int>();
        public Search()
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(1,100); i++)
            {
                search.Add(random.Next(0, 2));
            }

        }

        public void ShowList()
        {
           
            foreach (var item in this.search)
            {
                Console.Write(item + " ");
                
            }
        }

        public void SearchList()
        {
            int Count = 0;
            int num=0;
            int firstIndex = 0;
            int lastIndex = 0;
            for (int i=0; i<search.Count; i++)
            {
                if (search[i] == 1)
                {
                  
                    Count++;
                    if (num < Count)
                    {
                        lastIndex = i;
                        num = Count;
                    }

                }
                if (search[i] == 0)
                {
                    
                    Count = 0;
                }
            }
            firstIndex = lastIndex - (num-1);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Найбiльша послiдовнить одиниць: ");
            Console.ResetColor();
            Console.WriteLine(num);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Iнтервал iндексiв: ");
            Console.ResetColor();
            Console.WriteLine($"[{firstIndex};{lastIndex}]");
            
        }

    }
     
}
