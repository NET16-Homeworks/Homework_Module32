using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Homework_Module32
{
    internal class Task1
    {
        public void UniqueNames(List<string>[] ListOfNames) 
        {
            int i = 1;
            foreach (var list in ListOfNames)
            {
                HashSet<string> newList = new HashSet<string>(list);
                Console.WriteLine($"Уникальные имена списка номер{i}:"); 

                foreach (var name in newList)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine($"Итого уникальных имён:{ newList.Count}");
                i++;
            }
        }
    }
}
