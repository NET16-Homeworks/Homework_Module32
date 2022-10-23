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
            Console.WriteLine("List of symbols:");
            foreach (var currSymbol in listOfSymbols)
            {
                Console.WriteLine($"{currSymbol}" + "\t");
            }
            Console.WriteLine("List of unique symbols:");
            foreach (var symbol in listOfSymbols.Distinct())
            {
                var count = listOfSymbols.Count(chr => chr == symbol);
                Console.WriteLine("The number of symbols: {0} = {1}", symbol, count);
            }
        }

        //Создайте метод, который будет принимать строку.Сгруппируйте символы строки таким
        //    образом, чтобы у вас получилась коллекция со значениями уникальных символов
        //    и количеством их повторений в стоке.Выведите уникальные символы и их количество
        //    на консоль.Подсказка: для решения задачи можете использовать Dictionary.

        public void GetSymbolsAndCountArray(string str)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            char[] chars = str.ToCharArray();

            foreach(char chr in chars)
            {
                if (symbols.ContainsKey(chr))
                {
                    symbols[chr]++;
                }

                else
                {
                    symbols.Add(chr, 1);
                }
                
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"Char: {symbol.Key}; count of chars in the string: {symbol.Value}");
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