using System;
using System.Collections.Generic;

namespace Project_Euler
{
    public class Problem17
    {
        public void ReturnResult()
        {
            var basicNums = new List<int>()
            {
                "one".Length,
                "two".Length,
                "three".Length,
                "four".Length,
                "five".Length,
                "six".Length,
                "seven".Length,
                "eight".Length,
                "nine".Length
            };

            var nonBaiscNums = new List<int>()
            {
                "ten".Length,
                "eleven".Length,
                "twelve".Length,
                "thirteen".Length,
                "fourteen".Length,
                "fifteen".Length,
                "sixteen".Length,
                "seventeen".Length,
                "eighteen".Length,
                "nineteen".Length
            };

            var tenthNums = new List<int>()
            {
                "twenty".Length,
                "thirty".Length,
                "forty".Length,
                "fifty".Length,
                "sixty".Length,
                "seventy".Length,
                "eighty".Length,
                "ninety".Length
            };

            var and = "and".Length;
            var hundred = "hundred".Length;
            var onethousand = "onethousand".Length;


            var basicTotal = 0;
            var nonBasicTotal = 0;
            var tenthTotal = 0;
            var hundredTotal = 0;
            var finaleTotal = 0;
            var forEachBasic = 0;
            var extra = 0;

            for(var b = 0; b < basicNums.Count; b++)
            {
                forEachBasic += basicNums[b];
            }

            for(var n = 0; n < nonBaiscNums.Count; n++)
            {
                nonBasicTotal += nonBaiscNums[n];
            }

            for(int c = 0; c < 10; c++)
            {
                for(var t = 0; t < tenthNums.Count; t++)
                {
                    tenthTotal += tenthNums[t];
                }
            }

            for(int c = 0; c < 8; c++)
            {
                for(var b = 0; b < basicNums.Count; b++)
                {
                    tenthTotal += basicNums[b];
                }
            }

            extra += ( forEachBasic + nonBasicTotal + tenthTotal + hundredTotal );

            for(int eachHundred = 0; eachHundred < 9; eachHundred++)
            {
                finaleTotal += ( forEachBasic + nonBasicTotal + tenthTotal + hundredTotal );
            }

            for(int hundredand = 0; hundredand < 891; hundredand++)
            {
                hundredTotal += ( hundred + and );
            }

            for(int hundreds = 0; hundreds < 9; hundreds++)
            {
                hundredTotal += hundred;
            }

            for(int eachBasic = 0; eachBasic < 100; eachBasic++)
            {
                basicTotal += forEachBasic;
            }

            finaleTotal += ( basicTotal + hundredTotal + extra + onethousand );

            Console.WriteLine("Problem 17:\nThe sum of all the letters between 1 to 1000 is " + finaleTotal);
        }
    }
}