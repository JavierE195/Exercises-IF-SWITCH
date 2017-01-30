using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int status;
            double income;
            double tax;
            string line1;
            string line2;

            Console.WriteLine("Please select the number of your current status if:");
            Console.WriteLine("1. You are single.");
            Console.WriteLine("2.Married filing jointly or Qualifying widow(er)");
            Console.WriteLine("3.Married filing separately");
            Console.WriteLine("4. Head of household");

            line1 = Console.ReadLine();
            status = int.Parse(line1);

            if (status < 5 && status > 0)
            {
                Console.Write("Please enter your income: $");
                line2 = Console.ReadLine();
                income = double.Parse(line2);

                if (status == 1)
                {
                    if (income > 0)
                    {
                        if (income > 0 && income <= 24000)
                        {
                            tax = (income * 0.15) / 100;
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 24000 && income <= 58150)
                        {
                            tax = (((income - 24000) * 0.28) + 3600);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 58150 && income <= 121300)
                        {
                            tax = (((income - 58150) * 0.31) + 13162);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 121300 && income <= 263750)
                        {
                            tax = (((income - 121300) * 0.36) + 32738.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 263750)
                        {
                            tax = (((income - 263750) * 0.396) + 84020.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                    }
                    else
                    {
                        Console.Write("Please enter an amount greater than 0");
                    }
                }
                else if (status == 2)
                {
                    if (income > 0)
                    {
                        if (income > 0 && income <= 40100)
                        {
                            tax = (income * 0.15) / 100;
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 40100 && income <= 96900)
                        {
                            tax = (((income - 40100) * 0.28) + 6015);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 96900 && income <= 147700)
                        {
                            tax = (((income - 96900) * 0.31) + 21919);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 147700 && income <= 263750)
                        {
                            tax = (((income - 147700) * 0.36) + 37667);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 263750)
                        {
                            tax = (((income - 263750) * 0.396) + 79445);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                    }
                    else
                    {
                        Console.Write("Please enter an amount greater than 0");
                    }
                }
                else if (status == 3)
                {
                    if (income > 0)
                    {
                        if (income > 0 && income <= 20050)
                        {
                            tax = (income * 0.15) / 100;
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 20050 && income <= 48450)
                        {
                            tax = (((income - 20050) * 0.28) + 3007.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 48450 && income <= 73850)
                        {
                            tax = (((income - 48050) * 0.31) + 10959.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 73850 && income <= 131875)
                        {
                            tax = (((income - 73850) * 0.36) + 18833.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 131875)
                        {
                            tax = (((income - 131875) * 0.396) + 39722.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                    }
                    else
                    {
                        Console.Write("Please enter an amount greater than 0");
                    }
                }
                else if (status == 4)
                {
                    if (income > 0)
                    {
                        if (income > 0 && income <= 32150)
                        {
                            tax = (income * 0.15) / 100;
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 32150 && income <= 83050)
                        {
                            tax = (((income - 32150) * 0.28) + 4822.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 83050 && income <= 134500)
                        {
                            tax = (((income - 83050) * 0.31) + 19074.50);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 134500 && income <= 263750)
                        {
                            tax = (((income - 134500) * 0.36) + 35024);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                        else if (income > 263750)
                        {
                            tax = (((income - 263750) * 0.396) + 81554);
                            Console.Write("Your tax amount is ${0}", tax);
                        }
                    }
                    else
                    {
                        Console.Write("Please enter an amount greater than 0");
                    }
                }
            }          
   
            else
            {
                Console.Write("Please enter a number from 1 to 4");
            }


            Console.ReadKey();
        }
    }
}
