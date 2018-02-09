using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project_Euler
{
    public class Problem16
    {
        public void ReturnResult()
        {
            List<BigInteger> NumList = new List<BigInteger>();

            int inputNum = 2;
            int powerOf = 1000;

            double finalValue = 0;

            for(int i = 0; i < powerOf; i++)
            {
                NumList.Add(inputNum);
            }

            var total = NumList.Aggregate((currentSum, item) => currentSum*item);

            var numArray = total.ToString().ToCharArray();

            for(int i = 0; i < numArray.Length; i++)
            {
                var nextInt = char.GetNumericValue(numArray[i]);
                finalValue += nextInt;
            }

            Console.WriteLine("Problem 16:\nThe Sum of of the numbers from " + inputNum + " to the power of " + powerOf + " Equals to " + finalValue);
        }
    }
}