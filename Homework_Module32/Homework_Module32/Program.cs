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
                        firstTask.GetUniqueNames(listsOfNames);
                        break;

                    case 2:
                        var secondTask = new SecondTask.SecondTask();
                        secondTask.LinkedListNumbers();
                        break;

                    case 3:
                        var thirdTask = new ThirdTask.ThirdTask();
                        thirdTask.NumbersOfUniqueSymbols("Hello world");
                        break;

                    case 4:
                        Random rnd = new Random();
                        int[] numbers = new int[10];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = rnd.Next(0, 1000);
                        }
                        Console.WriteLine("Removing all array elements: ");
                        foreach (var item in numbers)
                        {
                            Console.Write("|" + item);
                        }
                        Console.WriteLine("|");

                        var fourthTask = new FourthTask.FourthTask(numbers);
                        Console.WriteLine("Removing required array elements: ");
                        foreach (var item in fourthTask.GetEnumerable())
                        {
                            Console.Write("|" + item);
                        }
                        Console.WriteLine("|");
                        break;

                    default:
                        Console.WriteLine("You entered wrond number!");
                        break;
                }
                Menu();
                key = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Menu()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Task #1 - \"Вывод уникальных имен\"");
            Console.WriteLine("2. Task #2 - \"LinkedList коллекция\"");
            Console.WriteLine("3. Task #3 - \"Уникальные символы в строке\"");
            Console.WriteLine("4. Task #4 - \"Вывод элементов массива, используя yield\"");
            Console.WriteLine("5. Exit from program");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}