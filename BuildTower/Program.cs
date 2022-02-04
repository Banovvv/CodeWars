using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTower
{
    internal class Program
    {
        //Build Tower by the following given argument:
        //number of floors(integer and always greater than 0).
        //Tower block is represented as *
        //C#: returns a string[];
        static void Main(string[] args)
        {
            int nFloors = 3;
            Console.WriteLine(string.Join(",", TowerBuilder(nFloors)));
        }

        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];
            int spaces = nFloors - 1;
            for (int floor = 0; floor < nFloors; floor++, spaces--)
            {
                int asterisk = floor * 2 + 1;
                tower[floor] = new string(' ', spaces) + new string('*', asterisk) + new string(' ', spaces);
            }
            return tower;
        }
    }
}
