using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal sealed class MyArray
    {
        private readonly List<int> _list;
        public int Count { get => _list.Count; }
        public MyArray(List<int> list)
        {
            _list = list;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = _list.Count-1; i >= 0; i--)
            {
                if ((_list[i] % 2 == 0 || _list[i] % 3 == 0) && _list[i] != 0)
                {
                    yield return _list[i];
                }
            }
        }
    }
}
