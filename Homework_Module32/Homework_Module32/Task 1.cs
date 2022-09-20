using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task_1
    {
        public void ShowUsUniqueNames(List<string>[] listNames)
        {
            int counter = 0;
            foreach (var listName in listNames)
            {
                counter++;
                ListProcessionUniqueNames(listName, counter);
            }
        }

        private void ListProcessionUniqueNames(List<string> names, int listNum)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            foreach (var name in names)
            { 
                 uniqueNames.Add(name);                
            }
            
            if (uniqueNames.Count != 0)
            {
                Tabs();
                Console.WriteLine($"List №{listNum} unique names:");
                Tabs();
                foreach (var name in uniqueNames)
                {
                    Console.Write($"| {name}\t");
                }
                Console.WriteLine();
                Tabs();
                Console.WriteLine($"Total names: {uniqueNames.Count}");
                Tabs();
            }
            else
            {
                Console.WriteLine("There is no names in this list!");
            }
        }

        void Tabs()
        {
            Console.WriteLine("-----------------------------");
        }
    }
}
