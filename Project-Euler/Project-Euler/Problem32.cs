using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem32
    {

        public void ReturnResult()
        {
            var result = 0;

            for(var i = 1; i < 10; i++)
            {
                result += i;
            }

            Console.Write("Problem 32:\nThe result is " + result);
        }
    }
}