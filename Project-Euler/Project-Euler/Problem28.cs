using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem28
    {
        public void ReturnResult()
        {
            var currentRight = 1;
            var currentLeft = 1;

            var counter = 4;

            var total = 0;

            for(int i = 1; i < 1001; i++)
            {
                currentRight += ( i*2 );

                currentLeft += counter;

                if(i%2 == 0)
                {
                    counter += 4;
                }

                total += ( currentLeft + currentRight );
            }
            Console.WriteLine("Problem 28:\nThe sum of the diagonals in a 1001 by 1001 spiral is " + (total+1));
        }
    }
}