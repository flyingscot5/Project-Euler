using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem27
    {
        public bool IsPrime(int number)
        {
            if(number == 1) return false;
            if(number == 2) return true;
            if(number%2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for(int i = 3; i <= boundary; i += 2)
            {
                if(number%i == 0) return false;
            }

            return true;
        }

        public void ReturnResult()
        {
            var numN = 0;

            var numA = 0;
            var numB = 0;

            var total = 0;

            for(var a = -1000; a < 1000; a++)
            {
                for(var b = -1000; b <= 1000; b++)
                {
                    var n = 0;

                    while(IsPrime(Math.Abs(n*n + a*n + b)))
                    {
                        n++;
                    }

                    if(n > numN)
                    {
                        numA = a;
                        numB = b;
                        numN = n;
                    }
                }
            }

            total = ( numA*numB );

            Console.WriteLine("Problem 27:\nThe Product of the coefficient a and b is " + total);
        }
    }
}