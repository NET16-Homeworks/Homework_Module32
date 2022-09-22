using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32.FirstTask
{
    internal class FirstTask
    {
        public void GetUniqueNames(IEnumerable<string>[] listNames)
        {
            int listNumber = 1;
            foreach (var names in listNames)
            {
                FindUniqueNamesInCollection(names, listNumber);
                listNumber++;
            }
        }
        private void FindUniqueNamesInCollection(IEnumerable<string> names, int listNumber)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            foreach (var name in names)
            {
                uniqueNames.Add(name);
            }
            ShowUniqueNamesFromCollection(uniqueNames, listNumber);
        }
        private void ShowUniqueNamesFromCollection(IEnumerable uniqueNames, int listNumber)
        {
            int count = 0;
            Console.WriteLine($"Displaying all unique names in the list {listNumber}:");
            foreach (var name in uniqueNames)
            {
                Console.Write($"\"{name}\", ");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine($"Total number of unique names: {count}");
        }
    }
}
