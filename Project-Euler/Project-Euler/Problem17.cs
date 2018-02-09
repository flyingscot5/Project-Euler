using System;

namespace Project_Euler
{
    public class Problem17
    {
        public void ReturnResult()
        {
            int counter = 0;

            int singlesTotal = 0;

            int patternLessTotal = 0;

            int doublesTotal = 0;

            //1-9
            var singles = "3,3,5,4,4,3,5,5,4";
            //10-19
            var patternLess = "3,6,6,8,8,7,7,9,8,8";
            //20-90 in tens
            var doubles = "6,6,5,5,5,7,6,6";

            var arrayOfSingles = singles.Split(',');
            var arrayOfPatternLess = patternLess.Split(',');
            var arrayOfDoubles = doubles.Split(',');

            for(int j = 0; j < 9; j++)
            {
                //sum singles
                for(int i = 0; i < 9; i++)
                {
                    singlesTotal += Int32.Parse(arrayOfSingles[i]);
                }


                //sum of patternless
                for(int i = 0; i < 10; i++)
                {
                    patternLessTotal += Int32.Parse(arrayOfPatternLess[i]);
                }


                //sum of the rest
                for(int l = 0; l < 10; l++)
                {
                    for(int i = 0; i < 8; i++)
                    {
                        doublesTotal += Int32.Parse(arrayOfDoubles[i]);
                    }
                }
                doublesTotal += 8*36;
            }

            counter += singlesTotal + patternLessTotal + doublesTotal + 7*9;
            Console.WriteLine("Problem 17:\n" + counter);
        }
    }
}