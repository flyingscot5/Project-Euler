using System;

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

            Console.WriteLine("Problem 6:\nAnwser " + sumOfNatural + " - " + sumOfSquare + " total " + result);
        }
    }
}