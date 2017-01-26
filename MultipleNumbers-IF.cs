using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleNumbers_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIn;
            int divisor3;
            int divisor3Reminder;
            int divisor5;
            int divisor5Reminder;
            int divisor7;
            int divisor7Reminder;
            string line1;

            Console.Write("Insert a number: ");
            line1 = Console.ReadLine();
            numberIn = int.Parse(line1);

            divisor3 = numberIn / 3;
            divisor3Reminder = numberIn % 3;

            if (divisor3Reminder != 0)
            {
                Console.Write("\n{0} is not multiple of 3", numberIn);
            }
            else
            {
                Console.Write("\n{0} is multiple of 3", numberIn);
            }

            divisor5 = numberIn / 5;
            divisor5Reminder = numberIn % 5;

            if (divisor5Reminder != 0)
            {
                Console.Write("\n{0} is not multiple of 5", numberIn);
            }
            else
            {
                Console.Write("\n{0} is multiple of 5", numberIn);
            }
            divisor7 = numberIn / 7;
            divisor7Reminder = numberIn % 7;

            if (divisor7Reminder != 0)
            {
                Console.Write("\n{0} is not multiple of 7", numberIn);
            }
            else
            {
                Console.Write("\n{0} is multiple of 7", numberIn);
            }
            Console.ReadKey();
        }
    }
}
