using System;

namespace Beginner_LostWithoutAMap
{
    internal class Program
    {
        //Given an array of integers, return a new array with each value doubled.
        //For example:
        //[1, 2, 3] --> [2, 4, 6]
        static void Main(string[] args)
        {
            int[] x = { 2, 2, 2, 2, 2, 2 };
            Console.WriteLine(string.Join(" ", Maps(x)));
        }

        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;
        }
    }
}
