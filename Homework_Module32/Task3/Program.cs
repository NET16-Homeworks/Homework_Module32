using System.Xml;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var dictionary = GroupByChar(line);

            Print(dictionary);
        }

        static Dictionary<char, int> GroupByChar(string str)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var @char in str)
            {
                if (dictionary.ContainsKey(@char))
                {
                    dictionary[@char]++;
                }
                else
                {
                    dictionary.Add(@char, 1);
                }
            }

            return dictionary;
        }

        static void Print(Dictionary<char, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -- {item.Value}");
            }
        }
    }
}