using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_Module32
{
    internal class Task3
    {
        public string str = "sdjkfhsdkjfj128sdsdsds391278371289";
        
        public void SearchUniqueChars(string str)
        {
            var uniqueChars = new Dictionary<char, int>();
            foreach(var ch in str)
            {
                if(!uniqueChars.ContainsKey(ch))
                {
                    uniqueChars.Add(ch, 1);
                }
                else
                {
                    uniqueChars[ch]++;
                }
            }
            Print(uniqueChars);
        }
        private void Print(Dictionary<char,int> uniqueChars)
        {
            foreach(var pair in uniqueChars)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
        }
    }
}
