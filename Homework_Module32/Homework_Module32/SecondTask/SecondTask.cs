using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_Module32.SecondTask
{
    internal class SecondTask
    {
        private const int SIZE_OF_LINKED_LIST = 100_000;

        public void LinkedListNumbers()
        {
            Random random = new Random();
            var linkedList = new LinkedList<int>();
            for (int i = 0; i < SIZE_OF_LINKED_LIST; i++)
            {
                linkedList.AddLast(random.Next(0, 100));
            }
            LinkedListNode<int> node = linkedList.First;

            var index = 0;
            while (node != null)
            {
                if(node.Next != null && node.Previous != null)
                {
                    if (node.Next.Value % 2 == 0 && node.Previous.Value % 2 == 1)
                    {
                        var t = node.Previous.Value;
                        node.Previous.Value = node.Next.Value;
                        node.Next.Value = t;
                        Console.WriteLine($"Value => {node.Value}, Index of iteration => {index}");
                    }
                }
                index++;
                node = node.Next;
            }
        }
    }
}
