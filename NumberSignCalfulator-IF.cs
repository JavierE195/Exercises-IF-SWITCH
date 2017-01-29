using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSignCalculator_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberIn;
            string line1;

            Console.Write("\nInsert a number: ");
            line1 = Console.ReadLine();
            numberIn = decimal.Parse(line1);

            if (numberIn != 0)
            {
                if (numberIn > 0)
                {
                    Console.Write("\nThe number is positive");
                }
                else
                {
                    Console.Write("\nThe number is negative");
                }
            }
            else
            {
                Console.Write("\nThe number is zero");
            }

            Console.ReadKey();
        }
    }
}
