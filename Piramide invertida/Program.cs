using System;

namespace Piramide_invertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            staircase(6);
        }

        public static void staircase(int n)
        {

            string valueSharp = "";
            int nn = 0;

            for (int i = 0; i < n; i++)
            {
                nn = n - (i + 1);
                string blank = ("").PadLeft(nn);

                valueSharp = valueSharp + "#";
                Console.WriteLine(blank + valueSharp);
            }


        }
    }
}
