using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
   public class Second
    {
        public LinkedList<int> CreateIntLinkedListWithValues(int numberOfValues, int minValue, int maxValue)
        {
            LinkedList<int> list = new();

            var random = new Random();
            for (int i = 1; i < numberOfValues; i++)
            {
                var randomNumber = random.Next(minValue, maxValue);
                list.AddLast(randomNumber);
            }

            return list;
        }

        public void SwapEvenOdd(LinkedList<int> list)
        {
            var TekuscheeZnach = list.First;

            for (int i = 1; i < list.Count; i++)
            {
                var predValue = TekuscheeZnach?.Previous?.Value;
                var sledValue = TekuscheeZnach?.Next?.Value;
                bool SledZnachChet = (sledValue != null && (sledValue % 2) == 0);
                bool PredZnachChet = (predValue != null && (predValue % 2) != 0);

                if (SledZnachChet && PredZnachChet)
                {
                    int? tempPrev = predValue;
                    int? tempNext = sledValue;

                    sledValue = tempPrev;
                    predValue = tempNext;

                    Console.WriteLine($"current index: {i}, current value: {TekuscheeZnach?.Value}");
                }

                TekuscheeZnach = TekuscheeZnach?.Next;
            }
        }
    }
}
