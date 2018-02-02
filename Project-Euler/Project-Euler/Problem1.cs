using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem1
    {
        public List<int> ListOfMultiples = new List<int>();

        public decimal SumOfMultiples;


        public void GetMultiples()
        {
            int count = 0;
            bool returnMultiple = true;

            while(returnMultiple)
            {
                ++count;

                if(count >= 1000)
                {
                    returnMultiple = false;
                }
                else if((count%3 == 0) || (count % 5 == 0))
                {
                    ListOfMultiples.Add(count);
                }
            }

            foreach(var multiple in ListOfMultiples)
            {
                SumOfMultiples += multiple;
            }

            Console.WriteLine("Sum of Multiples 3 or 5 " + SumOfMultiples);
        }
    }
}