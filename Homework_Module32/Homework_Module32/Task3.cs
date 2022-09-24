using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task3
    {
        public void GetSymbolsAndCount(string listOfSymbols)
        {
            Console.WriteLine("List of unique symbols:");
            foreach (var currSymbol in listOfSymbols)
            {
                Console.WriteLine($"{currSymbol}" + "\t");
            }

            foreach (var symbol in listOfSymbols.Distinct())
            {
                var count = listOfSymbols.Count(chr => chr == symbol);
                Console.WriteLine("The number of symbols: {0} = {1}", symbol, count);
            }
        }
    }
}
//попробую вывести с дикшинари также
//Dictionary<char, int> symbols = new Dictionary<char, int>();

//    for (int i = 0; i<listOfSymbols.Length; i++)
//    {
//        foreach (var currSymbol in listOfSymbols)
//        {
//            symbols.TryGetValue(currSymbol, out int count);
//count++;
//            Console.WriteLine($"{currSymbol}, {i}" + "\t");
//        }