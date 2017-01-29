using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSignCalculator_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.Write("\nPlease insert your grade: ");
                int grade = int.Parse(Console.ReadLine());

                if (grade > 100)
                {
                    Console.Write("Please enter a grade from 0 to 100");
                }
                else if (grade < 101 && grade > 89)
                {
                    Console.Write("Congratulations, you got an A");
                }
                else if (grade < 90 && grade > 79)
                {
                    Console.Write("You got a B");
                }
                else if (grade < 80 && grade > 69)
                {
                    Console.Write("You got a C");
                }
                else if (grade < 70 && grade > 50)
                {
                    Console.Write("You got a D");
                }
                else if (grade < 51)
                {
                    Console.Write("Sorry, you got an F");
                }
                Console.Write("\nPress any key to continue");
                Console.ReadKey();
            }
        }
    }
}
