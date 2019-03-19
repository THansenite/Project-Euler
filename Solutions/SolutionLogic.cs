using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class SolutionLogic
    {
        #region Question1
        public int MultiplesOf3and5(int iterations)
        {
            var sum = 0;

            for (int i = 1; i < iterations; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
        #endregion

        #region Question2
        public int EvenFibonacci(int maxValue)
        {
            var previous = 1;
            var current = 2;
            var result = 0;

            while (current <= maxValue)
            {
                if (current % 2 == 0)
                    result += current;

                var newFib = previous + current;
                previous = current;
                current = newFib;
            }

            return result;
        }
        #endregion

        #region Question3
        public int LargestPrimeFactor(int valueToCheck)
        {
            return FindFactors(valueToCheck, 0);
        }

        private int FindFactors(int value, int largestPrime)
        {
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    var test = FindFactors(i, largestPrime);
                    if (i > largestPrime)
                    {
                        largestPrime = i;
                    }
                }
            }
            if (largestPrime == 0)
            {
                largestPrime = value;
            }

            return largestPrime;
        }
        #endregion

        #region Question4
        public int LargestPalendromeFactor(int maxValue)
        {

            var palindromes = new List<int>();
            var product = 0;
            palindromes.Add(product);

            for (int i = 1; i <= maxValue; i++)
            {
                for (int j = 1; j <= maxValue; j++)
                {
                    product = j * i;

                    if (IsPalindrome(product))
                    {
                        palindromes.Add(product);
                    }
                }
            }
            
            return palindromes.Max();
        }
        private bool IsPalindrome(int value)
        {
            var valString = value.ToString();
            char[] charArray = valString.ToCharArray();

            return charArray.SequenceEqual(charArray.Reverse().ToList());
        }
        #endregion
    }
}
