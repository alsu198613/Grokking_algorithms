//1 loop sum
using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }

        private static int Sum(IEnumerable<int> arr)
        {
            var total = 0;
            foreach (var x in arr)
            {
                total += x;
            }
            return total;
        }
    }
}

// 2 recursive sum
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }

        private static int Sum(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return list.Take(1).First() + Sum(list.Skip(1));
        }
    }
}

//3 recursive count
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Count(new[] { 1, 2, 3, 4 }));
        }

        private static int Count(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return 1 + Count(list.Skip(1));
        }
    }
}

// 4 recursive max
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Max(new[] { 1, 3, 2, 5, 9, 8 }));
        }

        private static int Max(IEnumerable<int> list)
        {
            if (!list.Any()) throw new ArgumentException(nameof(list));
            if (list.Count() == 1) return list.First();
            if (list.Count() == 2) return list.First() > list.Skip(1).Take(1).First() ? list.First() : list.Skip(1).Take(1).First();
            var sub_max = Max(list.Skip(1));
            return list.First() > sub_max ? list.First() : sub_max;
        }
    }
}

//5 quicksort
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arr = new[] { 10, 5, 2, 3 };
            Console.WriteLine(string.Join(", ", QuickSort(arr)));
        }

        private static IEnumerable<int> QuickSort(IEnumerable<int> list)
        {
            if (list.Count() <= 1) return list;
            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return QuickSort(less).Union(new List<int> { pivot }).Union(QuickSort(greater));
        }
    }
}

//6 get GCD
using System;
using System.Collections.Generic;
using System.Linq;

namespace GCD
{
    public class program
    {

        //Get great Comman Divisor
        public static int GetGCD(int FirstNumber, int SecondNumber)
            => SecondNumber == default ? FirstNumber : GetGCD(SecondNumber, FirstNumber % SecondNumber);

        //Get great Comman Divisor of list
        public static int GetGCDList(List<int> lst)
        {
            var result = lst[0];
            result = GetGCD(result, lst.Skip(1).FirstOrDefault());
            return result;
        }

        static void Main(string[] args)
        {
            var lst = new List<int> { 32, 696, 40, 50 };
            var GCD = GetGCD(640, 1680);
            var GCDList = GetGCDList(lst);
            Console.WriteLine(GCD);
            Console.WriteLine(GCDList);
        }
    }
}