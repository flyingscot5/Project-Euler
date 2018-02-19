using System;
using System.Diagnostics;

namespace Project_Euler
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            string userInput;
            if(args.Length == 0)
            {
                Console.WriteLine("Select Which problem to run \nAll Problems: all \nProblem1: 1 \nProblem2: 2 \nProblem3: 3 \nProblem4: 4 \nProblem5: 5 " +
                                  "\nProblem6: 6 \nProblem7: 7 \nProblem8: 8 \nProblem9: 9 \nProblem10: 10 \nProblem11: 11  \nProblemV2: 11V2 " +
                                  "\nProblem12: 12 \nProblem13: 13  \nProblemV2: 13V2 \nProblem15: 14 \nProblem15: 15 \nProblem16: 16 \nProblem17: 17" +
                                  " \nProblem18: 18 \nProblem19: 19 \nProblem20: 20 \nProblem21: 21 \nProblem22: 22 \nProblem23: 23 \nProblem24: 24" +
                                  "\nProblem25: 25 \nProblem26: 26");
                userInput = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                userInput = args[0];
            }

            if(userInput == "all")
            {
                for(int i = 1; i <= 27; i++)
                {
                    Main(new[] {i.ToString()});
                }
            }
            else
            {
                var stopwatch = Stopwatch.StartNew();

                switch(userInput)
                {
                    case "1":
                        var problem1 = new Problem1();
                        problem1.ReturnResult();
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
                        problem4.LargestPalindromeProduct();
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
                    case "11V2":
                        var problem11V2 = new Problem11V2();
                        problem11V2.ReturnResult();
                        break;
                    case "12":
                        var problem12 = new Problem12();
                        problem12.ReturnResult();
                        break;
                    case "13-":
                        var problem13 = new Problem13();
                        problem13.ReturnResult();
                        break;
                    case "13":
                        var problem13V2 = new Problem13V2();
                        problem13V2.ReturnResult();
                        break;
                    case "14":
                        var problem14 = new Problem14();
                        problem14.ReturnResult();
                        break;
                    case "15":
                        var problem15 = new Problem15();
                        problem15.ReturnResult();
                        break;
                    case "16":
                        var problem16 = new Problem16();
                        problem16.ReturnResult();
                        break;
                    case "17":
                        var problem17 = new Problem17();
                        problem17.ReturnResult();
                        break;
                    case "18":
                        var problem18 = new Problem18();
                        problem18.ReturnResult();
                        break;
                    case "19":
                        var problem19 = new Problem19();
                        problem19.ReturnResult();
                        break;
                    case "20":
                        var problem20 = new Problem20();
                        problem20.ReturnResult();
                        break;
                    case "21":
                        var problem21 = new Problem21();
                        problem21.ReturnResult();
                        break;
                    case "22":
                        var problem22 = new Problem22();
                        problem22.ReturnResult();
                        break;
                    case "23":
                        var problem23 = new Problem23();
                        problem23.ReturnResult();
                        break;
                    case "24":
                        var problem24 = new Problem24();
                        problem24.ReturnResult();
                        break;
                    case "25":
                        var problem25 = new Problem25();
                        problem25.ReturnResult();
                        break;
                    case "26":
                        var problem26 = new Problem26();
                        problem26.ReturnResult();
                        break;
                    case "27":
                        var problem27 = new Problem27();
                        problem27.ReturnResult();
                        break;
                    case "28":
                        var problem28 = new Problem28();
                        problem28.ReturnResult();
                        break;

                    case "67":
                        var problem67 = new Problem67();
                        problem67.ReturnResult();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
                Console.WriteLine("\nTook " + stopwatch.ElapsedMilliseconds + "ms\nOr " + stopwatch.ElapsedTicks + " ticks\n\n-----------------");
            }


            if(args.Length == 0)
            {
                Console.WriteLine("Press Any key to Close!");
                Console.ReadKey();
            }
        }
    }
}