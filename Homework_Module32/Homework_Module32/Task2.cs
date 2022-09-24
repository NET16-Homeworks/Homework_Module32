using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task2
    {
        public LinkedList<int> GetRandomNumbers(int minValue, int maxValue)
        {
            Random random = new Random();
            Console.WriteLine("Random integers within 0 and 100:");
            LinkedList<int> listOfNumbers = new LinkedList<int>();

            for (int n = 0; n <= 100; n++)
            {
                listOfNumbers.AddLast(random.Next(minValue, maxValue));
                //Console.WriteLine("{0,4}", random.Next(0, 100));
            }

            return listOfNumbers;
        }

        public void GetIndexAndValueOfIteration(LinkedList<int> listOfNumbers)
        {
            LinkedListNode<int> node;

            for (node = listOfNumbers.First; node != null; node = node.Next)
            {
                if(node.Previous is null || node.Next is null)
                {
                    continue;
                }

                    if (node.Previous.Value % 2 != 0 && node.Next.Value % 2 == 0)
                    {
                        var current = node.Previous.Value;
                        node.Previous.Value = node.Next.Value;
                        node.Next.Value = current;

                        Console.WriteLine(node.Value);
                    }
                }
            }
        }
    }

