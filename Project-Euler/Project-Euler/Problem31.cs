using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem31
    {
        public void ReturnResult()
        {
            var count = 0;

            for(var a = 200; a >= 0; a -= 200)
            {
                for(var b = a; b >= 0; b -= 100)
                {
                    for(var c = b; c >= 0; c -= 50)
                    {
                        for(var d = c; d >= 0; d -= 20)
                        {
                            for(var e = d; e >= 0; e -= 10)
                            {
                                for(var f = e; f >= 0; f -= 5)
                                {
                                    for(var g = f; g >= 0; g -= 2)
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Problem 31:\n£2 can be made " + count + " Ways");
        }
    }
}