using System;
using System.Linq;

namespace FindTheOddInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };

            Console.WriteLine(find_it(seq));
        }

        public static int find_it(int[] seq)
        {
            int counterOne = 0;
            int index = 0;

            for (int i = 0; i < seq.Length; i++)
            {
                int counterTwo = seq.Count(f => f == seq[i]);

                if (counterTwo % 2 != 0 && counterTwo > counterOne)
                {
                    counterOne = counterTwo;
                    index = i;
                }
            }

            return seq[index];
        }
    }
}
