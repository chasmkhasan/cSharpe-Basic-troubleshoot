using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Koden ska skriva ut alla siffror mellan 1 till 100 men skriver bara ut till nummer 99

            for (int i = 1; i < 101; i++) // increase number 
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 100; i++) // add "="
            {
                Console.WriteLine(i);
            }
        }
    }
}
