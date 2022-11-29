using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eftersom i är 1 i exemplet nedan förväntar vi oss att koden inte ska göra något men nu skriver den ut "Two". 
            // Varför blir det så och hur löser vi det så att det inte blir någon utskrift om i är 1?

            int i = 1;

            switch (i)
            {
                case 1: // add break. Bcz case 1 doesnt shown anything information that is why its move to case 2.
                    break; // if we write break it will not move foreward.
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
