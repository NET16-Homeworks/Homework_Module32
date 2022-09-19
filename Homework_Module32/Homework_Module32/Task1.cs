using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task1
    {
        public List<string>[] arrayWithListsOfUsernames = new List<string>[]
        {
            new List<string>()
            {
                "Sasha",
                "Kolya",
                "Ira",
                "Sasha"
            },
            new List<string>()
            {
                "Vanya",
                "Kolya",
                "Vlad",
                "Vanya"
            },
            new List<string>()
            {
                "Ira",
                "Sasha",
                "Nikita",
                "Ira"
            }
        };
        public void ListsWithUsernames(List<string>[] usernames)
        {
            var uniqueNames = new HashSet<string>();
            foreach (var list in usernames)
            {
                uniqueNames.SymmetricExceptWith(list);
                Print(uniqueNames);
                Console.WriteLine($"Count of unique names: {uniqueNames.Count}\n");
                uniqueNames.Clear();
            }
        }
        private void Print(HashSet<string> names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
