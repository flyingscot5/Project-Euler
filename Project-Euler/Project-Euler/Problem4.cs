using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int ReverseNum(int numInput)
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

        public void ReturnResult()
        {
            int CalcNum = 0;
            for(int count1 = 999; count1 > 100; count1--)
            {
                for(int count2 = 999; count2 > 100; count2--)
                {
                    CalcNum = count1*count2;

                    if(CalcNum == ReverseNum(CalcNum))
                    {
                        PalindromeList.Add(new PalindromeObj()
                        {
                            Num1 = count1,
                            Num2 = count2,
                            PalindromeNum = CalcNum
                        });
                    }
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

            Console.WriteLine(PalindromeList[largestIndex].Num1 + " * " + PalindromeList[largestIndex].Num2 + " results in the palindrome Number " + largestPalindrome);
        }
    }
}