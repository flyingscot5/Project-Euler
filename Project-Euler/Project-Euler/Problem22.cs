using System;
using System.IO;
using System.Linq;

namespace Project_Euler
{
    public class Problem22
    {
        public void ReturnResult()
        {
            var listOfNames = File.ReadAllLines("../../Resources/Problem22/names.txt").First();

            var arrayOfNames = listOfNames.Split(',');

            var sortedNames = arrayOfNames.OrderBy(n => n);

            var index = 0;

            double finaleTotal = 0;

            foreach(var name in sortedNames)
            {
                var total = 0;

                index++;
                var charArrayOfNames = name.ToCharArray();
                foreach(var eachChar in charArrayOfNames)
                {
                    var currentNum = Convert.ToUInt16(eachChar);
                    total += ( currentNum - 64 );
                }
                total *= index;
                finaleTotal += total;
            }

            Console.WriteLine("Problem 22:\nThe total of all the name scores " + finaleTotal);
        }
    }
}