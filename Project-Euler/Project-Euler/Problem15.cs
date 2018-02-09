using System;

namespace Project_Euler
{
    public class Problem15
    {
        public int GridHeight = 20 + 1;
        public int GridWidth = 20 + 1;

        private long[,] _gridArray;

        public void InsertToArray()
        {
            _gridArray = new long[GridWidth, GridHeight];

            for(var y = 0; y < GridHeight; y++)
            {
                for(var x = 0; x < GridWidth; x++)
                {
                    _gridArray[x, y] = 1;
                }
            }
        }

        public void ReturnResult()
        {
            InsertToArray();

            for(var y = 0; y < GridHeight; y++)
            {
                for(var x = 0; x < GridWidth; x++)
                {
                    try
                    {
                        long topNum = _gridArray[x, y - 1];
                        long leftNum = _gridArray[x - 1, y];

                        _gridArray[x, y] = ( topNum + leftNum );
                    }
                    catch(Exception)
                    {
                        // ignored
                    }
                }
            }

            Console.WriteLine("Problem 15:\nTotal number of routes is " + _gridArray[20, 20]);
        }
    }
}