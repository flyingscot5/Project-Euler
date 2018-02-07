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
            Console.WriteLine("Select Which problem to run \nProblem1: 1 \nProblem2: 2 \nProblem3: 3 \nProblem4: 4 \nProblem5: 5 " +
                              "\nProblem6: 6 \nProblem7: 7 \nProblem8: 8 \nProblem9: 9 \nProblem10: 10 \nProblem11: 11 \nProblem12: 12 \nProblem13: 13");

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
                case "5":
                    var problem5 = new Problem5();
                    problem5.ReturnResult();
                    break;
                case "6":
                    var problem6 = new Problem6();
                    problem6.ReturnResult();
                    break;
                case "7":
                    var problem7 = new Problem7();
                    problem7.ReturnResult();
                    break;
                case "8":
                    var problem8 = new Problem8();
                    problem8.ReturnResult();
                    break;
                case "9":
                    var problem9 = new Problem9();
                    problem9.ReturnResult();
                    break;
                case "10":
                    var problem10 = new Problem10();
                    problem10.ReturnResult();
                    break;
                case "11":
                    var problem11 = new Problem11();
                    problem11.ReturnResult();
                    break;
                case "12":
                    var problem12 = new Problem12();
                    problem12.ReturnResult();
                    break;
                case "13":
                    var problem13 = new Problem13();
                    problem13.ReturnResult();
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