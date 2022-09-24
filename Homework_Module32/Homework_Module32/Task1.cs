using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task1
    {
        public void GetNames(List<string>[] listOfNames)
        {
            Console.WriteLine("List of unique names:");
            foreach (var listOfName in listOfNames)
            {
                HashSet<string> uniqueNames = new HashSet<string>(listOfName);

                foreach (var uniqueName in uniqueNames)
                {
                    Console.WriteLine(uniqueName);
                }

                if (uniqueNames.Count != 0)
                {
                    Console.WriteLine(uniqueNames.Count);
                }

                else
                {
                    Console.WriteLine("There are no names in the list.");
                }
            }
        }
        //how to receive message from the system "9" when counting?
        //currently output is 3,3,3
    }
}

