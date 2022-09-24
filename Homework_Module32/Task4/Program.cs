namespace Task4
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var list = Enumerable.Range(1, 10).Select(x => random.Next(0, 20)).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var myArray = new MyArray(list);

            Console.WriteLine();
            Console.WriteLine("New Array:");
            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}