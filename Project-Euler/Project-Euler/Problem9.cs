using System;

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
                    Console.WriteLine("Problem 9:\n" + A + " " + B + " " + c);
                    Console.WriteLine("Product of abc is " + ( A*B*c ));
                }
            }
        }
    }
}