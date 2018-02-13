using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem26
    {
        public void ReturnResult()
        {
            bool longestRecurring = false;

            var counter = 0;
            double baseNum = 1;
            double currentNum = 0;

            int longestNumLength = 0;
            double longestNum = 0;


            while(!longestRecurring)
            {
                counter++;
                currentNum = baseNum/counter;

                var currentLength = currentNum.ToString().Length;

                if(currentLength > longestNumLength)
                {
                    longestNumLength = currentLength;
                    longestNum = currentNum;
                    Console.WriteLine(longestNumLength);
                }

                if(longestNumLength > 100)
                {
                    longestRecurring = true;
                }
            }

            Console.WriteLine(longestNumLength);
            Console.WriteLine(longestNum);
        }
    }
}