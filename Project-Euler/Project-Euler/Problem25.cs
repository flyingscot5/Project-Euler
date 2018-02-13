using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem25
    {
        public void ReturnResult()
        {
            BigInteger seq1 = 1;
            BigInteger seq2 = 1;
            BigInteger total = 0;
            var counter = 2;

            while(total.ToString().Length < 1000)
            {
                counter++;
                total = ( seq1 + seq2 );
                seq1 = seq2;
                seq2 = total;
            }

            Console.WriteLine("Problem 25:\nThe first Fibo sequence to have over 1000 digits is " + counter);
        }
    }
}