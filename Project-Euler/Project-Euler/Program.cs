using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select Which problem to run \nProblem1: 1 \nProblem2: 2 \nProblem3: 3 \nProblem4: 4");

            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    var problem1 = new Problem1();
                    problem1.GetMultiples();
                    break;

                case "2":
                    var problem2 = new Problem2();
                    problem2.ReturnResult();
                    break;
                case "3":
                    var problem3 = new Problem3();
                    problem3.ReturnResult();
                    break;
                case "4":
                    var problem4 = new Problem4();
                    problem4.ReturnResult();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }


            Console.WriteLine("Press Any key to Close!");
            Console.ReadKey();
        }
    }
}