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
        public void ShowUniqueNames(IEnumerable<string>[] listNames)
        {
            int listNumber = 1;
            foreach (var names in listNames)
            {
                FindUniqueNamesInList(names, listNumber);
                listNumber++;
            }
        }

        private void FindUniqueNamesInList(IEnumerable<string> names, int listNumber)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            foreach (var name in names)
            {
                uniqueNames.Add(name);
            }
            ShowUniqueNames(uniqueNames, listNumber);
        }
        private void ShowUniqueNames(IEnumerable uniqueNames, int listNumber)
        {
            Console.WriteLine($"Displaying all unique names in the list {listNumber}:");
            foreach (var name in uniqueNames)
            {
                Console.Write($"\"{name}\", ");
            }
            Console.WriteLine();
        }
    }
}
