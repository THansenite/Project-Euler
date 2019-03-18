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
            //Problem 1
            Problem001 problem1 = new Problem001();
            var result1 = problem1.MultiplesOf3and5(1000);
            //PrintOutput("Problem 1: ", result1.ToString());

            //Problem 2
            Problem002 problem2 = new Problem002();
            var result2 = problem2.EvenFibonacci(4000000);
            //PrintOutput("Problem 2: ", result2.ToString());

            //Problem 3
            Problem003 problem3 = new Problem003();
            var result3 = problem3.LargestPrimeFactor(600851475143);
        }

        private static void PrintOutput(string problem, string answer)
        {
            Console.WriteLine(problem + answer);
            Console.ReadKey();
        }
    }
}
