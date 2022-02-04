using System;
using System.Collections.Generic;
using System.Linq;

namespace CategorizeNewMember
{
    internal class Program
    {
        //The Western Suburbs Croquet Club has two categories of membership, Senior and Open.They would like your help with an application form that will tell prospective members which category they will be placed.
        //To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
        //Input will consist of a list of pairs. Each pair contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.
        //Output will consist of a list of string values (in Haskell: Open or Senior) stating whether the respective member is to be placed in the senior or open category.
        //Example
        //input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
        //output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]
        static void Main(string[] args)
        {
            var data = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
            Console.WriteLine(string.Join(" ", OpenOrSenior(data)));
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var output = new List<string>();
            foreach (var item in data)
            {
                if (item[0] >= 55 && item[1] > 7) output.Add("Senior");
                else output.Add("Open");
            }
            return output;
        }
    }
}
