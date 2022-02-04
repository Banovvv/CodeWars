using System;

namespace ANeedleInTheHaystack
{
    internal class Program
    {
        //Can you find the needle in the haystack?
        //Write a function findNeedle() that takes an array full of junk but containing one "needle"
        //After your function finds the needle it should return a message(as a string) that says:
        //"found the needle at position " plus the index it found the needle, so:
        //find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
        //should return "found the needle at position 5"
        static void Main(string[] args)
        {
            object[] haystack = { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            Console.WriteLine(FindTheNeedle(haystack));
        }

        public static string FindTheNeedle(object[] haystack)
        {
            int position = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] != null && haystack[i].ToString() == "needle")
                {
                    position = i;
                    break;
                }
            }

            return $"found the needle at position {position}";
        }
    }
}
