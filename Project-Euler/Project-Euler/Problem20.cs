using System;
using System.Numerics;

namespace Project_Euler
{
    public class Problem20
    {

        public void ReturnResult()
        {

            var startNum = 100;

            BigInteger total = 1;

            double finaleTotal = 0;

            for (var i = startNum; i > 0; i--)
            {
                total *= i;
            }

            var totalarray = total.ToString().ToCharArray();

            for(int i = 0; i < totalarray.Length; i++)
            {
                var nextInt = char.GetNumericValue(totalarray[i]);
                finaleTotal += nextInt;
            }

            Console.WriteLine("Problem 20:\nThe sum of the digits in the number is " + finaleTotal);
        }
    }
}
