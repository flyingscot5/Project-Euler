using System;

namespace Project_Euler
{
    public class Problem1
    {
        public int SumOfMultiples;

        public void ReturnResult()
        {
            for(int count = 1; count < 1000; count++)
            {
                if(( count%3 == 0 ) || ( count%5 == 0 ))
                {
                    SumOfMultiples += count;
                }
            }

            Console.WriteLine("Problem 1:\nSum of Multiples 3 or 5 is " + SumOfMultiples);
        }
    }
}