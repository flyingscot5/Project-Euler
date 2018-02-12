using System;

namespace Project_Euler
{
    public class Problem21
    {
        public void ReturnResult()
        {
            double finalTotal = 0;

            double lastNum = 0;

            for(int counter = 2; counter < 10000; counter++)
            {
                double num1 = counter;

                double total1 = 0;

                for(int i = 2; i <= num1; i++)
                {
                    double current = num1/i;

                    if(current%1 == 0)
                    {
                        total1 += current;
                    }
                }


                double num2 = total1;
                double total2 = 0;

                for(int i = 2; i <= num2; i++)
                {
                    double current = num2/i;

                    if(current%1 == 0)
                    {
                        total2 += current;
                    }
                }

                if(total2 == num1 && total1 == num2 && total1 != total2 && lastNum != total2)
                {
                    finalTotal += ( total1 + total2 );

                    lastNum = total1;
                }
            }
            Console.WriteLine("Problem 21:\nThe sum of all the amicable pairs below 10,000 is " + finalTotal);
        }
    }
}