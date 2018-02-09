using System;

namespace Project_Euler
{
    public class Problem19
    {
        public void ReturnResult()
        {
            int sundayCounter = 0;

            for(var currentYear = 1901; currentYear <= 2000; currentYear++)
            {
                for(var month = 1; month <= 12; month++)
                {
                    if(( new DateTime(currentYear, month, 1) ).DayOfWeek == DayOfWeek.Sunday)
                    {
                        sundayCounter++;
                    }
                }
            }
            Console.WriteLine("Problem 19:\nThere are " + sundayCounter + " sundays at the start of the month in a 100 years");
        }
    }
}