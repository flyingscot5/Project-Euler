using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem5
    {
        public void ReturnResult()
        {
            int counter = 0;

            bool allDividable = false;

            while (!allDividable)
            {
                ++counter;

                bool isDividable = true;

                for (var i = 1; i <= 20; i++)
                {
                    if (counter % i != 0)
                    {
                        isDividable = false;
                        break;
                    }
                }

                if (isDividable)
                {
                    allDividable = true;
                }
            }
            Console.WriteLine("Dividable by 1 to 20 is " + counter);
        }
    }
}