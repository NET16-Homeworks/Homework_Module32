using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task_2
    {
        public void LinkedListSwap(int howMuchNumbers)
        {
            Random random = new Random();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < howMuchNumbers; i++)
            {
                numbers.AddLast(random.Next(0, 100));
            }

            LinkedListNode<int> node;

            int index = 0;
            for (node = numbers.First; node != null; node = node.Next)
            {
                if (node.Next != null && node.Previous != null)
                {
                    //Console.WriteLine($"{node.Previous.Value} | {node.Value} | {node.Next.Value}");

                    if (node.Previous.Value % 2 == 1 && node.Next.Value % 2 == 0)
                    {
                        var temp = node.Previous.Value;
                        node.Previous.Value = node.Next.Value;
                        node.Next.Value = temp;
                        Console.WriteLine($"Индекс иттерации - {index}, значение - {node.Value}");
                        //Console.WriteLine($"{node.Previous.Value} | {node.Value} | {node.Next.Value}");

                    }

                }
                index++;
            }
        }
    }
}
