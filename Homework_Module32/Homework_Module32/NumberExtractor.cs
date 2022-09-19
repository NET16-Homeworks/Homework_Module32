using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class NumberExtractor
    {
        public NumberExtractor(Stack<int> numbers)
        {
            Numbers = numbers;
        }
        public Stack<int> Numbers { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            Stack<int> outputNumbers = new Stack<int>();
            int count = Numbers.Count;
            for (int i = 0; i < count; i++)
            {
                int temp = Numbers.Pop();
                if (temp % 2 == 0 || temp % 3 == 0)
                {
                    outputNumbers.Push(temp);
                }
            }
            foreach (var number in outputNumbers)
            {
                yield return number;
            }
            
        }
    }
}
