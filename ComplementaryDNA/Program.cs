using System;

namespace ComplementaryDNA
{
    internal class Program
    {
        //In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". You function receives one side of the DNA; you need to return the other complementary side. DNA strand is never empty or there is no DNA at all.
        //Example: (input --> output)
        //"ATTGC" --> "TAACG"
        //"GTAT" --> "CATA
        static void Main(string[] args)
        {
            string dna = "ATTGC";
            Console.WriteLine(MakeComplement(dna));
        }

        public static string MakeComplement(string dna)
        {
            char[] dnaComplement = new char[dna.Length];
            for (int i = 0; i < dna.Length; i++)
            {
                dnaComplement[i] = dna[i];
                switch (dnaComplement[i])
                {
                    case 'A': dnaComplement[i] = 'T'; break;
                    case 'T': dnaComplement[i] = 'A'; break;
                    case 'C': dnaComplement[i] = 'G'; break;
                    case 'G': dnaComplement[i] = 'C'; break;
                }
            }
            return string.Join("", dnaComplement);
        }
    }
}
