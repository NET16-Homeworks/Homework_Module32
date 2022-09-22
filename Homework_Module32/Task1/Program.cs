using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace Task1
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            List<string>? firstListNames = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(
                "FirstList.json"));
            List<string>? secondListNames = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(
                "SecondList.json"));
            List<string>? thirdListNames = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(
                "ThirdList.json"));

            var names = new List<List<string>>
            {
                firstListNames,
                secondListNames,
                thirdListNames
            };

            ShowUniqueNames(names);
        }

        static void ShowUniqueNames(List<List<string>> peopleNames)
        {
            var uniqueName = new HashSet<string>();
            int listNumber = 1;

            foreach (var listNames in CollectionsMarshal.AsSpan(peopleNames))
            {
                foreach (var name in CollectionsMarshal.AsSpan(listNames))
                { 
                    if (!uniqueName.Contains(name))
                    {
                        uniqueName.Add(name);
                    }
                    else
                    {
                        uniqueName.Remove(name);
                    }
                }

                Console.WriteLine("Unique names in list number #" + listNumber++);
                PrintNames(uniqueName);
                Console.WriteLine("Amount of unique names is: " + uniqueName.Count);

                uniqueName.Clear();
            }
        }

        static void PrintNames(HashSet<string> names)
        {
            Console.WriteLine("========================");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("========================");
        }
    }
}