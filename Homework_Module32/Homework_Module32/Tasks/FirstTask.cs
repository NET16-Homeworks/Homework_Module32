namespace Homework_Module32.Tasks
{
    public class FirstTask
        {
        public void GetListUniqueNames(List<List<string>> listOfLists)
        {
            foreach (List<string> list in listOfLists)
            {
                var uniqueNames = new HashSet<string>(list);

                Console.WriteLine("List of unique names: ");

                foreach (var name in uniqueNames)
                {
                    Console.WriteLine(name);
                }

                Console.WriteLine($"Unique names count: {uniqueNames.Count}");
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
