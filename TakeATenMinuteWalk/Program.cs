using System;
using System.Linq;

namespace TakeATenMinuteWalk
{
    internal class Program
    {
        //You live in the city of Cartesia where all roads are laid out in a perfect grid.You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk.The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.
        static void Main(string[] args)
        {
            string[] walk = { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" };
            Console.WriteLine(IsValidWalk(walk));
        }

        public static bool IsValidWalk(string[] walk)
        {
            var north = walk.Where(d => d == "n").Count();
            var south = walk.Where(d => d == "s").Count();
            var east = walk.Where(d => d == "e").Count();
            var west = walk.Where(d => d == "w").Count();

            return north == south && east == west && walk.Length == 10;
        }
    }
}
