using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double nested loops
            // 2d arrays

            Console.WriteLine("Double Nested Loops");
            Console.WriteLine();

            //make a loop in another loop
            //inside of inner loop display loop variables
            //predict what will be displayed BEFORE!



          //  int numbase = 10; // how many digits
            for (int i = 1; i <= 10; i++)  //numbase - 1, after <=
            {
                for (int j = 1; j <= 10; j++) // i++ is also i + 1
                {
                    for (int k = 1; k <= 10; k++) 
                    {
                        Console.WriteLine(i + ", " + j + ", " + k); // ", "
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exix...");
            Console.ReadKey(true);
        }
    }
}
