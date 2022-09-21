using System;
using Homework_Module32.FirstTask;

namespace Homework_Module32
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            int key = Convert.ToInt32(Console.ReadLine());
            while (key != 5)
            {
                switch (key)
                {
                    case 1:
                        FirstTask.FirstTask firstTask = new FirstTask.FirstTask();
                        List<string>[] listsOfNames = new List<string>[3]
                        {
                            new List<string>()
                            {
                                "Pavel", "Alexey", "Pavel", "Vitya", "Anastasiya", "Alina", "Alina"
                            },
                            new List<string>()
                            {
                                "Nikita", "Anton", "Vladimir", "Kostya", "Kostya"
                            },
                            new List<string>()
                            {
                                "Pavel", "Lena", "Ilya", "Roman", "Gleb", "Ilya", "Matvey", "Gleb"
                            },

                        };
                        firstTask.ShowUniqueNames(listsOfNames);
                        break;

                    case 2:
                        var secondTask = new SecondTask.SecondTask();
                        secondTask.LinkedListNumbers();
                        break;

                    case 3:
                        var thirdTask = new ThirdTask.ThirdTask();
                        Dictionary<char, int> pairs = new Dictionary<char, int>();
                        thirdTask.NumbersOfUniqueSymbols("Hello world");
                        foreach (var pair in pairs)
                        {
                            
                        }
                        break;

                    case 4:
                        //Random rnd = new Random();
                        //int[] numbers = new int[10];
                        //for (int i = 0; i < numbers.Length; i++)
                        //{
                        //    numbers[i] = rnd.Next(0, 1000);
                        //}

                        //var fourthTask = new FourthTask.FourthTask(numbers);
                        //var array = fourthTask.GetNumbers();
                        //foreach (var item in array)
                        //{
                        //    Console.WriteLine(item);
                        //}
                        //break;

                    default:
                        Console.WriteLine("You entered wrond number");
                        break;
                }
                Menu();
                key = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Menu()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Task #1 - \"Вывод уникальных имен\"");
            Console.WriteLine("2. Task #2");
            Console.WriteLine("3. Task #3");
            Console.WriteLine("4. Task #4");
            Console.WriteLine("5. Exit from program");
            Console.WriteLine("--------------------------------------");
        }
    }
}