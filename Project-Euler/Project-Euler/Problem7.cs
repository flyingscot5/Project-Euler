using System;

namespace Project_Euler
{
    public class Problem7
    {
        public bool IsPrime(int number)
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
            int primeCount = 0;
            int finalePrime = 0;
            bool allPrimes = false;

            int count = 0;

            while(!allPrimes)
            {
                if(primeCount >= 10001)
                {
                    finalePrime = count;
                    allPrimes = true;
                }

                ++count;

                if(IsPrime(count))
                {
                    ++primeCount;
                }
            }

            Console.WriteLine("Problem 7:\nThe 10001 Prime Number is " + finalePrime);
        }
    }
}