using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem9
    {
        public int A;
        public int B;

        public void ReturnResult()
        {
            for(A = 1; A <= 1000/3; A++)
            {
                for(B = A + 1; B <= 1000/2; B++)
                {
                    var leftOver = A*A + B*B;
                    var c = 1000 - A - B;

                    if(leftOver != c*c) continue;
                    Console.WriteLine(A + " " + B + " " + c);
                    Console.WriteLine("Product of abc is " + ( A*B*c ));
                }
            }
        }
    }
}