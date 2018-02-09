using System;

namespace Project_Euler
{
    public class Problem14
    {
        public double LargestChain = 0;
        public double LargestChainNum = 0;

        public void ReturnResult()
        {
            for(double n = 0; n < 1000000; n++)
            {
                double currentNum = n;
                double counter = 1;

                while(currentNum > 1)
                {
                    counter++;
                    if(currentNum%2 == 0)
                    {
                        currentNum /= 2;
                    }
                    else
                    {
                        currentNum = ( currentNum*3 ) + 1;
                    }
                }

                if(counter > LargestChain)
                {
                    LargestChainNum = n;
                    LargestChain = counter;
                }
            }
            Console.WriteLine("Problem 14:\nLargest Term Chain is " + LargestChain + " Starting Num was " + LargestChainNum);
        }
    }
}