using System.Collections.Generic;
using System.Linq;
using System;

namespace UniqueInOrder
{
    internal class Program
    {
        //Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

        //For example:
        //uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
        //uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
        //uniqueInOrder([1,2,2,3,3])       == {1,2,3}
        static void Main(string[] args)
        {
            var iterable = "AAAABBBCCDAABBB".ToList();
            Console.WriteLine(string.Join(" ", UniqueInOrder(iterable)));
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            return iterable.Where((x, i) => i == 0 || !Equals(x, iterable.ElementAt(i - 1)));
        }
    }
}
