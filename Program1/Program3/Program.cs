using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Koden genererar fel och körs inte.
            

            for (int i = 1; i <= 5; i++) // add ++
            {
                for (int j = 1; j <= i; j++) // ++
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
