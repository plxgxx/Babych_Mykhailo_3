using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace Task2
{
    
    class Sort
    {
        private string js;
       public  Dictionary<int, string> d = new Dictionary<int, string>()

        {
                 {81,"Math" },
                 {83,"Physics"},
                 {87,"Chemistry" }
        };
        Dictionary<int, string> sortDict = new Dictionary<int, string>();

        public void ShowDictionary()
        {
            foreach (var dict in d)
            {
                Console.WriteLine(dict + " ");

            }
        }

        public void SortDictionary()
        {
            

            foreach (var dict in d.Reverse())
            {
                sortDict.Add(dict.Key, dict.Value);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Відсортований словарь: ");
            Console.ResetColor();
            foreach (var dict in sortDict)
            {
                Console.WriteLine(dict + " ");
            }
        }
        public void SaveToJson()
        {
            js = JsonConvert.SerializeObject(this.sortDict);
            var pathout = Path.Combine(Environment.CurrentDirectory, "varietyout.json");
            File.WriteAllText(pathout, js);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Данi створенi у файлi json");
            Console.ResetColor();
        }
        
             
        


      

    }
}
