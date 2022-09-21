namespace Homework_Module32.Tasks
{
    public partial class HomeTask
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
            var currentValue = list.First;

            for (int i = 1; i < list.Count; i++)
            {
                var prevValue = currentValue?.Previous?.Value;
                var nextValue = currentValue?.Next?.Value;
                bool isNextValueEven = (nextValue != null && (nextValue % 2) == 0);
                bool isPrevValueOdd = (prevValue != null && (prevValue % 2) != 0);

                if (isNextValueEven && isPrevValueOdd)
                {
                    int? tempPrev = prevValue;
                    int? tempNext = nextValue;

                    nextValue = tempPrev;
                    prevValue = tempNext;

                    Console.WriteLine($"current index: {i}, current value: {currentValue?.Value}");
                }

                currentValue = currentValue?.Next;
            }
        }
    }
}
