using System;

namespace Project_Euler
{
    public class Problem3
    {
        public long CalcNum = 600851475143;

        public void ReturnResult()
        {
            for(long count = 2; CalcNum > 1; count++)
            {
                if(CalcNum%count != 0)
                    continue;
                while(CalcNum%count == 0)
                {
                    CalcNum /= count;
                }
                if(CalcNum == 1)
                {
                    Console.WriteLine("Problem 3:\nThe Largest Prime Factors is " + count);
                    break;
                }
            }
        }
    }
}