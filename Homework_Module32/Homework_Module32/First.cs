using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
  public class First
    {
        public void GetListUniqueNames(List<List<string>> listOfLists)
        {
            foreach (List<string> list in listOfLists)
            {
                var uniqueNames = new HashSet<string>(list);

                Console.WriteLine("List of unique names: ");

                foreach (var name in uniqueNames)
                {
                    Console.WriteLine(name);
                }

                Console.WriteLine($"Unique names count: {uniqueNames.Count}");
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
