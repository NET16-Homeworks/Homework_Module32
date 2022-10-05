using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task2
    {
        public LinkedList<int> RandomNumbers()
        {
            Random random = new Random();
            
            LinkedList<int> listOfRandomNumbers = new LinkedList<int>();

            for (int i = 0; i <= 100; i++)   // 100_000
            {
                listOfRandomNumbers.AddLast(random.Next(0, 100));                
            }

            return listOfRandomNumbers;
        }

        public void ChangePosition(LinkedList<int> listOfRandomNumbers)
        {
            LinkedListNode<int> node;
            int index = 0;

            for (node = listOfRandomNumbers.First; node != null; node = node.Next)
            {
                if ((node.Next != null) && (node.Previous != null))
                {

                    if ((node.Previous.Value % 2 != 0) && (node.Next.Value % 2 == 0))
                    {
                        var number = node.Previous.Value;
                        node.Previous.Value = node.Next.Value;
                        node.Next.Value = number;

                        Console.WriteLine($"Текущий индекс итерации: {index}, текущее значение: {node.Value} ");

                    }
                    index++;
                }
            }
            
        }
    }
}
