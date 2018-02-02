using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem2
    {
        public List<int> FiboSequence = new List<int>();

        public void ReturnResult()
        {
            int total = 0;
            bool returnSequence = true;

            FiboSequence.Add(1);
            FiboSequence.Add(2);

            while(returnSequence)
            {
                var num1 = FiboSequence[FiboSequence.Count - 1];
                var num2 = FiboSequence[FiboSequence.Count - 2];

                var result = ( num1 + num2 );

                FiboSequence.Add(result);

                Console.WriteLine(result);

                if (result >= 4000000)
                {
                    returnSequence = false;
                }
            }



            FiboSequence.ForEach(item =>
            {
                if(item%2 == 0)
                {
                    total += item;
                }
            });

            Console.WriteLine("The Total Number of The even numbers in Fibonacci Sequence " + total);
        }
    }
}