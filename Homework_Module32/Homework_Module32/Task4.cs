using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task4
    {
        private readonly int[] _array;
        public Task4(int[] array)
        {
            _array = array;
        }

        public IEnumerator<int> GetEnumerator()
        {
            Console.WriteLine("WITH YIELD");
            Console.WriteLine("Elements of the array divided by 2 or 3:");
            int last = _array.Length - 1;
            for (int i = last; i >= 0; i--)
            {
                if (((_array[i] % 2) == 0) || ((_array[i] % 3) == 0))
                {
                    yield return _array[i];
                }
            }
        }

        public void GetElementsOfTheArray()
        {
            Console.WriteLine("WITHOUT YIELD");
            Console.WriteLine("Elements of the array divided by 2 or 3:");
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                if (((_array[i] % 2) == 0) || ((_array[i] % 3) == 0))
                {
                    Console.WriteLine(_array[i]);
                }
            }
        }
    }
}
