//1 check grosseries
using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Dictionary<string, decimal>();
            book.Add("apple", 0.67m);
            book.Add("milk", 1.49m);
            book.Add("avocado", 1.49m);
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

//2 check voted
using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        private static Dictionary<string, bool> _voted = new Dictionary<string, bool>();
        public static void Main(string[] args)
        {
            CheckVoter("tom");
            CheckVoter("mike");
            CheckVoter("mike");
        }

        private static void CheckVoter(string name)
        {
            if (_voted.ContainsKey(name))
            {
                Console.WriteLine("kick them out!");
            }
            else
            {
                _voted.Add(name, true);
                Console.WriteLine("let them vote!");
            }
        }
    }
}