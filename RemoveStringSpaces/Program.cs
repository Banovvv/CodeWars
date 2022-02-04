using System;

namespace RemoveStringSpaces
{
    internal class Program
    {
        // Simple, remove the spaces from the string, then return the resultant string.
        static void Main(string[] args)
        {
            string input = "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd";
            Console.WriteLine(NoSpace(input));
        }

        public static string NoSpace(string input)
        {

            return input.Replace(" ", "");
        }
    }
}
