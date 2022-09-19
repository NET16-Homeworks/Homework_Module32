using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task2
    {
        public LinkedList<int> numbers = new LinkedList<int>();
        private void InitializeList(LinkedList<int> numbers)
        {
            Random random = new Random();
            var node = numbers.AddFirst(random.Next(0, 100));
            for (int i = 0; i < 100_000; i++)
            {
                numbers.AddAfter(node, random.Next(0, 100));
            }
        }
        public void SwapNumbers(LinkedList<int> numbers)
        {
            InitializeList(numbers);
            var node = numbers.First.Next;
            for (int i = 0; i < 99_999; i++)
            {
                if (node.Previous.Value % 2 != 0 && node.Next.Value % 2 == 0)
                {
                    var temp = node.Previous.Value;
                    node.Previous.Value = node.Next.Value;
                    node.Next.Value = temp;
                }
                node = node.Next;
            }
            Print(numbers);  
        }
        public void Print(LinkedList<int> numbers)
        {
            foreach(var node in numbers)
            {
                Console.WriteLine(node);
            }
        }
    }
}
