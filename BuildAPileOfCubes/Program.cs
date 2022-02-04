using System;

namespace BuildAPileOfCubes
{
    internal class Program
    {
        //Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of n^3, the cube above will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.
        //You are given the total volume m of the building.Being given m can you find the number n of cubes you will have to build?
        //The parameter of the function findNb (find_nb, find-nb, findNb, ...) will be an integer m and you have to return the integer n such as n^3 + (n-1)^3 + ... + 1^3 = m if such a n exists or -1 if there is no such n.
        static void Main(string[] args)
        {
            long volume = 4183059834009;
            Console.WriteLine(FindNumberOfCubes(volume));
        }

        public static long FindNumberOfCubes(long volume)
        {
            int n;
            long currentVolume = 0;
            for (n = 0; currentVolume < volume;)
            {
                n++;
                currentVolume += (long)Math.Pow(n, 3);
            }

            return currentVolume == volume ? n : -1;
        }
    }
}
