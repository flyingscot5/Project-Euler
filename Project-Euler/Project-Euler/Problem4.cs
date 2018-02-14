using System;
using System.Collections.Generic;

namespace Project_Euler
{
    public class Problem4
    {
        public List<PalindromeObj> PalindromeList = new List<PalindromeObj>();

        public class PalindromeObj
        {
            public int Num1 { get; set; }
            public int Num2 { get; set; }
            public int PalindromeNum { get; set; }
        }

        private int Reverse(int numInput)
        {
            int reverseNum = 0;

            while(numInput > 0)
            {
                int remainder = numInput%10;
                reverseNum = ( reverseNum*10 ) + remainder;
                numInput = numInput/10;
            }

            return reverseNum;
        }

        public void LargestPalindromeProduct()
        {
            var CalcNum = 0;
            for(var count1 = 999; count1 > 100; count1--)
            {
                for(var count2 = 999; count2 > 100; count2--)
                {
                    CalcNum = count1*count2;
                    if(IsAPalindrome(CalcNum))
                        PalindromeList.Add(new PalindromeObj()
                        {
                            Num1 = count1,
                            Num2 = count2,
                            PalindromeNum = CalcNum });
                }
            }

            var largestPalindrome = 0;
            var largestIndex = 0;

            for(int i = 0; i < PalindromeList.Count; i++)
            {
                if(largestPalindrome < PalindromeList[i].PalindromeNum)
                {
                    largestPalindrome = PalindromeList[i].PalindromeNum;
                    largestIndex = i;
                }
            }

            Console.WriteLine("Problem 4:\n" + PalindromeList[largestIndex].Num1 + " * " + PalindromeList[largestIndex].Num2 + " results in the palindrome Number " + largestPalindrome);
        }

        private bool IsAPalindrome(int number)
        {
            if(number == Reverse(number))
            {
                return true;
            }
            return false;
        }
    }
}