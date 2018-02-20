using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project_Euler
{
    public class Problem29
    {
        List<BigInteger> listOfTerms = new List<BigInteger>();

        public void ReturnResult()
        {
            BigInteger result = 0;

            for(var i = 2; i <= 100; i++)
            {
                for(var j = 2; j <= 100; j++)
                {
                    BigInteger current = i;

                    for(var k = 1; k < j; k++)
                    {
                        current *= i;
                    }
                    listOfTerms.Add(current);
                }
            }

            result = listOfTerms.Distinct().Count();

            Console.WriteLine("Problem 29:\nThe amount of distinct term in the sequence are " + result);
        }
    }
}