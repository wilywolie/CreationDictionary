using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "ahmet");
            Console.WriteLine(dictionary.Length);
            foreach (var key in dictionary.Keys)
            {
                foreach (var value in dictionary.Values)
                {
                    Console.WriteLine(key);
                    Console.WriteLine(value);

                }
            }
        }
    }
}
