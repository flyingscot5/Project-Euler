using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    public class Problem18
    {
        public string InputNumbers =
            "75,95,64,17,47,82,18,35,87,10,20,04,82,47,65,19,01,23,75,03,34,88,02,77,73,07,63,67,99,65,04,28,06,16,70,92,41,41,26,56,83,40,80,70,33,41,48,72,33,47,32,37,16,94,29,53,71,44,65,25,43,91,52,97,51,14,70,11,33,28,77,73,17,78,39,68,17,57,91,71,52,38,17,14,91,43,58,50,27,29,48,63,66,04,68,89,53,67,30,73,16,69,87,40,31,04,62,98,27,23,09,70,98,73,93,38,53,60,04,23";

        public int GridHeight = 15;
        public int GridWidth = 15;

        private int[,] _gridArray;

        public void InsertToArray()
        {
            _gridArray = new int[GridWidth, GridHeight];

            int currentRow = 0;
            int triagleIndex = 0;

            for(var y = 0; y < GridHeight; y++)
            {
                currentRow++;
                for(var x = 0; x < currentRow; x++)
                {
                    string nextNumber = InputNumbers.Split(',')[triagleIndex];
                    triagleIndex++;

                    _gridArray[x, y] = Int32.Parse(nextNumber);
                }
            }
        }

        public void ReturnResult()
        {
            InsertToArray();

            var total = 0;
            var currentAxis = 0;

            for(var y = 0; y < GridHeight; y++)
            {
                var biggerNum = 0;
                var num1 = 0;
                var num2 = 0;
                var num3 = 0;
                var num4 = 0;
                var num5 = 0;
                try
                {
                    num1 = _gridArray[currentAxis, y];
                    num2 = _gridArray[currentAxis + 1, y];
                    num3 = _gridArray[currentAxis, y + 1];
                    num4 = _gridArray[currentAxis + 1, y + 1];
                    num5 = _gridArray[currentAxis + 2, y + 1];
                }
                catch(Exception)
                {
                    // ignored
                }

                var total1 = num1 + num3;
                var total2 = num1 + num4;
                var total3 = num2 + num4;
                var total4 = num2 + num5;

                var l = new List<int>() {total1, total2, total3, total4};
                var max = l.Max();
                var location = l.IndexOf(max);

                switch(location)
                {
                    case 0:
                        biggerNum = num1;
                        break;
                    case 1:
                        biggerNum = num1;
                        break;
                    case 2:
                        biggerNum = num2;
                        currentAxis++;
                        break;
                    case 3:
                        biggerNum = num2;
                        currentAxis++;
                        break;
                }
                total += biggerNum;
            }
            Console.WriteLine("Problem 18:\nThe Maximum total from top to bottom " + total);
        }
    }
}