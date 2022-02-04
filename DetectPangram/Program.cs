using System;
using System.Linq;

namespace DetectPangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(IsPangram(text));
        }

        public static bool IsPangram(string str)
        {
            return str.ToLower().Where(ch => char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
        }
    }
}
