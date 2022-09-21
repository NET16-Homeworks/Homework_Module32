namespace Homework_Module32.Tasks
{
    public partial class HomeTask
    {
        public void GetSymbolsCountInString(string @string)
        {
            Dictionary<char, int> symbols = new();

            foreach (char currentSymbol in @string)
            {
                if (symbols.TryGetValue(currentSymbol, out int count))
                {
                    symbols[currentSymbol] += 1;
                }
                else
                {
                    symbols.Add(currentSymbol, 1);
                }
            }

            foreach (var item in symbols)
            {
                Console.WriteLine($@"symbol '{item.Key}': {item.Value} times");
            }
        }
    }
}
