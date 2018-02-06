using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem6
    {
        public void ReturnResult()
        {
            int sumOfSquare = 0;
            int sumOfNatural = 0;
            int result = 0;

            for(var i = 1; i < 101; i++)
            {
                sumOfSquare += i*i;
                sumOfNatural += i;
            }

            sumOfNatural *= sumOfNatural;

            result = sumOfNatural - sumOfSquare;

            Console.WriteLine("Anwser " + sumOfNatural + " - " + sumOfSquare + " total " + result);
        }
    }
}