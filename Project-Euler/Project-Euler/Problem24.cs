using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem24
    {
        public List<int> PermutationList = new List<int>();


        public void ReturnResult()
        {

            for(int i = 0; i <= 9; i++)
            {
                PermutationList.Add(i);
            }

            for(var count = 0; count < 1000000; count++)
            {
                


            }
        }
    }
}