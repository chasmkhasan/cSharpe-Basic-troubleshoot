using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Koden har ingen output , varför?

            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j); // add j and Line.
                }

                Console.WriteLine();
                i++;
            }
        }
    }
}
