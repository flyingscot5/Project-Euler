using System;

namespace Project_Euler
{
    public class Problem30
    {
        public void ReturnResult()
        {
            var result = 0;

            for(var i = 1; i < 350000; i++)
            {
                var eachNum = i.ToString().ToCharArray();

                var currentTotal = 0;

                foreach(var num in eachNum)
                {
                    var num1 = int.Parse(num.ToString());
                    var current = num1;
                    for(var j = 1; j < 5; j++)
                    {
                        current = current*num1;
                    }

                    currentTotal += current;
                }

                if(currentTotal == i && currentTotal != 1)
                {
                    result += i;
                }
            }
            Console.WriteLine("Problem 30:\nThe Sum of all that can be written as the sum of fifth powers is " + result);
        }
    }
}