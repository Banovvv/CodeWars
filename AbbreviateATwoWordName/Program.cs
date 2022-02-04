using System;
using System.Linq;

namespace AbbreviateATwoWordName
{
    internal class Program
    {
        //Write a function to convert a name into initials.This kata strictly takes two words with one space in between them.
        //The output should be two capital letters with a dot separating them.
        //It should look like this:
        //Sam Harris => S.H
        //patrick feeney => P.F
        static void Main(string[] args)
        {
            string name = "David Mendieta";
            Console.WriteLine(AbbrevName(name));
        }

        public static string AbbrevName(string name)
        {
            string[] names = name.Split();
            return $"{names[0].ElementAt(0).ToString().ToUpper()}.{names[1].ElementAt(0).ToString().ToUpper()}";
        }
    }
}
