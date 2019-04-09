using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class Program
    {

        static void Main(string[] args)
        {
            SolutionLogic sl = new SolutionLogic();

            //Problem 1
            //var result1 = sl.MultiplesOf3and5(1000);
            //PrintOutput(1, result1.ToString());

            //Problem 2
            //var result2 = sl.EvenFibonacci(4000000);
            //PrintOutput(2, result2.ToString());

            //Problem 3
            // TODO: Runs wayyyyy too long
            //var result3 = sl.LargestPrimeFactor(600851475143);
            //PrintOutput(3, result3.ToString());

            //Problem 4
            //var result4 = sl.LargestPalendromeFactor(999);
            //PrintOutput(4, result3.ToString());

            //Problem 5
            //var result5 = sl.SmallestMultiple(20);
            //PrintOutput(5, result5.ToString());

            //Problem 6
            //var result6 = sl.SumSquareDifference(100);
            //PrintOutput(6, result6.ToString());

            //Problem 7

            //Problem 8
            //var result8 = sl.LargestProductInSeries(13, Constants.Q8_INPUT);
            //PrintOutput(8, result8.ToString());

            //Problem 9
            //var result9 = sl.PythagoreanTriplet(1000);
            //PrintOutput(9, result9.ToString());

            //Problem 10
            //Problem 11
            //Problem 12

            //Problem 13
            //var result13 = sl.LargeSum(Constants.Q13_INPUT, 10);
            //PrintOutput(13, result13.ToString());

            //Problem 14
            //var result14 = sl.LongestCollatzSequence(999999, 1);
            //PrintOutput(14, result14.ToString());
        }

        private static void PrintOutput(int problemNumber, string answer)
        {
            Console.WriteLine(String.Format("Problem {0}: {1}", problemNumber, answer));
            Console.ReadKey();
        }


    }
}
