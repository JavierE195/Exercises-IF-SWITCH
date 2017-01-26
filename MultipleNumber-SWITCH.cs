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
            int numberIn ;
            int divisor3 ;
            int divisor3Reminder = 0;
            int divisor5;
            int divisor5Reminder = 0;
            int divisor7;
            int divisor7Reminder = 0;
            string line1;

            Console.Write("Insert a number: ");
            line1 = Console.ReadLine();
            numberIn = int.Parse(line1);


            divisor3 = numberIn / 3;
            divisor3Reminder = numberIn % 3;

            
            switch (divisor3Reminder)
            {
                case 0:
                    Console.Write("\n{0} is multiple of 3", numberIn);
                    break;
                default:
                    Console.Write("\n{0} not is multiple of 3", numberIn);
                    break;
            }

            divisor5 = numberIn / 5;
            divisor5Reminder = numberIn % 5;

            switch (divisor5Reminder)
            {
                case 0:
                    Console.Write("\n{0} is multiple of 5", numberIn);
                    break;
                default:
                    Console.Write("\n{0} not is multiple of 5", numberIn);
                    break;
            }

            divisor7 = numberIn / 7;
            divisor7Reminder = numberIn % 7;

            switch (divisor7Reminder)
            {
                case 0:
                    Console.Write("\n{0} is multiple of 7", numberIn);
                    break;
                default:
                    Console.Write("\n{0} not is multiple of 7", numberIn);
                    break;
            }



            Console.ReadKey();
        }
    }
}
