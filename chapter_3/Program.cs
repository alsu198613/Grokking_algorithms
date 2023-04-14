// 1 countDown
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Countdown(5);
        }

        private static void Countdown(int i)
        {
            Console.WriteLine(i);

            // base case
            if (i <= 0) return;

            // recursive case
            Countdown(i - 1);
        }
    }
}

// 2 greet
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Greet("adit");
        }

        private static void Greet(string name)
        {
            Console.WriteLine($"hello, {name}!");
            Greet2(name);
            Console.WriteLine("getting ready to say bye...");
            Bye();
        }

        private static void Greet2(string name)
        {
            Console.WriteLine($"how are you, {name}?");
        }

        private static void Bye()
        {
            Console.WriteLine("ok bye!");
        }
    }
}

// 3 factorial

using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
        }

        private static int Fact(int x)
        {
            if (x <= 1) return 1;

            return x * Fact(x - 1);
        }
    }
}