using System;

namespace ConvertStringToNumber
{
    internal class Program
    {
        //We need a function that can transform a string into a number. What ways of achieving this do you know?
        static void Main(string[] args)
        {
            string str = "1405";
            Console.WriteLine(StringToNumber(str));
        }

        public static int StringToNumber(string str) => int.Parse(str);
    }
}
