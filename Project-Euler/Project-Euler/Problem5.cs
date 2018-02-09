using System;

namespace Project_Euler
{
    class Problem5
    {
        public void ReturnResult()
        {
            int counter = 20;

            bool allDividable = false;

            while(!allDividable)
            {
                ++counter;

                bool isDividable = true;

                for(var i = 2; i <= 20; i++)
                {
                    if(counter%i != 0)
                    {
                        isDividable = false;
                        break;
                    }
                }

                if(isDividable)
                {
                    allDividable = true;
                }
            }
            Console.WriteLine("Problem 5:\nDividable by 1 to 20 is " + counter);
        }
    }
}