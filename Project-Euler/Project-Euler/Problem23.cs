using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem23
    {
        public void ReturnResult()
        {

            double finalTotal = 0;

            for (int counter = 2; counter < 100; counter++)
            {
                double num1 = counter;

                double total1 = 0;

                for (int i = 2; i <= num1; i++)
                {
                    double current = num1 / i;

                    if (current % 1 == 0)
                    {
                        total1 += current;
                    }
                }

                double num2 = total1;
                double total2 = 0;

                for (int i = 2; i <= num2; i++)
                {
                    double current = num2 / i;

                    if (current % 1 == 0)
                    {
                        total2 += current;
                    }
                }
            }
            Console.WriteLine("Problem 23:\n" + finalTotal);
        }
    }
}