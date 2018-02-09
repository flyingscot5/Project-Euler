using System;

namespace Project_Euler
{
    public class Problem10
    {
        public bool IsPrime(double number)
        {
            if(number == 1) return false;
            if(number == 2) return true;
            if(number%2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for(int i = 3; i <= boundary; i += 2)
            {
                if(number%i == 0) return false;
            }

            return true;
        }


        public void ReturnResult()
        {
            double count = 0;
            double total = 0;

            while(count <= 2000000)
            {
                count++;


                if(IsPrime(count))
                {
                    total += count;
                }
            }
            Console.WriteLine("Problem 10:\nSum of all Primes Below 2,000,000 is " + total);
        }
    }
}