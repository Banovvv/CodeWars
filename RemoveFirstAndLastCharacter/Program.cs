using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFirstAndLastCharacter
{
    internal class Program
    {
        //It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the original string. You don't have to worry with strings with less than two characters.
        static void Main(string[] args)
        {
            string s = "eloquent";
            Console.WriteLine(Remove_char(s));
        }

        public static string Remove_char(string s)
        {
            return s.Remove(0, 1).Remove(s.Length-2, 1);
        }
    }
}
