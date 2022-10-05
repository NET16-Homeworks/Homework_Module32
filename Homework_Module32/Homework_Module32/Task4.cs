using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task4
    {
        private int[] _arr;
        public Task4(int[] Arr)
        {
            _arr = Arr;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = _arr.Length - 1; i >= 0; i--)
            {
                if (((_arr[i] % 2) != 0) && ((_arr[i] % 3) != 0))
                {
                    yield return _arr[i];
                }
            }
        }
    }
}


