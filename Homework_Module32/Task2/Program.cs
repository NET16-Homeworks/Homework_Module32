using System.Collections.Concurrent;
using System.Data;
using System.Xml.Linq;

namespace Task2
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            var ints = new LinkedList<int>();

            FillLinkedList(ints);
            Print(ints);

            ChangeLinkedList(ints);
            Print(ints);
        }

        static void Print(LinkedList<int> ints)
        {
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
        static void FillLinkedList(LinkedList<int> ints)
        {
            var random = new Random();

            for (int i = 0; i < 100_000; i++)
            {
                ints.AddLast(random.Next(0, 100));
            }
        }
        static void ChangeLinkedList(LinkedList<int> ints)
        {
            var headElement = ints?.First;

            int index = 0;
            while(headElement?.Next != null)
            {
                var previousElement = headElement?.Previous?.Value;
                var nextElement = headElement?.Next?.Value;

                bool NextElementIsNotNullAndMultiple = (nextElement != null && nextElement % 2 == 0);
                bool PreviousElementIsNotNullAndNotMultiple = (previousElement != null && previousElement % 2 != 0);

                if (PreviousElementIsNotNullAndNotMultiple && NextElementIsNotNullAndMultiple)
                {
                    (headElement.Previous.Value, headElement.Next.Value) = (headElement.Next.Value, headElement.Previous.Value);

                    Console.WriteLine($"Index: {index}, value: {headElement.Value}");
                }

                headElement = headElement?.Next;
                index++;
            }
        }
    }
}