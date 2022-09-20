using System.Collections;

namespace Homework_Module32.Classes
{
    internal class YieldClass
    {
        private List<int> numberList;

        public YieldClass(List<int> numberList)
        {
            this.numberList = numberList;
        }

        public IEnumerable GetEnumerable()
        {
            for (var i = numberList.Count - 1; i >= 0; i--)
            {
                if (((numberList[i] % 2) != 0) && ((numberList[i] % 3) != 0))
                {
                    yield return numberList[i];
                }
            }
        }
    }
}
