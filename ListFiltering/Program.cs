using System;
using System.Collections.Generic;

namespace ListFiltering
{
    internal class Program
    {
        //In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
        //Example
        //ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
        //ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 }) => { 1, 2, 0, 15}
        //ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 }) => { 1, 2, 231}
        static void Main(string[] args)
        {
            var list = new List<object>() { 1, 2, "a", "b" };
            Console.WriteLine(string.Join(" ", GetIntegersFromList(list)));
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var intList = new List<int>();
            foreach (var item in listOfItems)
            {
                if(item is int) intList.Add((int)item);
            }
            return intList;
        }
    }
}
