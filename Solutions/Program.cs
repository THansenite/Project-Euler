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
            //PrintOutput(3, result2.ToString());

            //Problem 4
            //var result3 = sl.LargestPalendromeFactor(999);
            //PrintOutput(4, result3.ToString());
        }

        private static void PrintOutput(int problemNumber, string answer)
        {
            Console.WriteLine(String.Format("Problem {0}: {1}", problemNumber, answer));
            Console.ReadKey();
        }
    }
}
