using System;

namespace Project_Euler
{
    public class Problem2
    {
        public void ReturnResult()
        {
            double total = 0;

            var num1 = 1;
            var num2 = 1;

            for(var result = 0; result < 4000000;)
            {
                if(( result%2 ) == 0)
                {
                    total += result;
                }

                result = ( num1 + num2 );
                num1 = num2;
                num2 = result;
            }


            Console.WriteLine("Problem 2:\nThe Total Number of The even numbers in Fibonacci Sequence " + total);
        }
    }
}