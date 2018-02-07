using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem12
    {
        public void ReturnResult()
        {
            double total = 0;
            var divisors = 0;
            var i = 1;

            while(divisors < 500)
            {
                divisors = 0;
                total += i;
                i++;
                
                int current = (int)Math.Sqrt(total);
                for (int J = 1; J < current; J++)
                {
                    if (total % J == 0)
                        divisors += 2;
                }
                if(current * current == total)
                {
                    divisors++;
                }
            }
            Console.WriteLine("First Triangle with over 500 divisors is " + total + " and has " + divisors + " divisors");
        }
    }
}