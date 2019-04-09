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

        //TODO: Question 3
        #region Question3
        public long LargestPrimeFactor(long initialValue)
        {
            for (long i = initialValue - 1; i > 0; i--)
            {
                if (initialValue % i == 0)
                {
                    if (i == 1)
                    {
                        // number is prime factor
                        return initialValue;
                    }
                    else if (i > 1)
                    {
                        return i;
                    }

                }
            }

            return 0;
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

        #region Question5
        public int SmallestMultiple(int maxDivisor)
        {
            var value = maxDivisor;

            while (!AllNumbersDivide(maxDivisor, value))
            {
                value++;
            }

            return value;
        }
        private bool AllNumbersDivide(int maxDivisor, int value)
        {
            for (int i = 1; i <= maxDivisor; i++)
            {
                if (value % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Question6
        public int SumSquareDifference(int value)
        {
            var sumTotal = 0;
            var sumOfSquares = 0;

            for (int i = 1; i <= value; i++)
            {
                sumTotal += i;
                sumOfSquares += i * i;
            }

            sumTotal = sumTotal * sumTotal;

            return sumTotal - sumOfSquares;
        }
        #endregion

        // TODO: Question 7
        #region Question7

        #endregion

        #region Question8
        public long LargestProductInSeries(int adjacentChars, string inputValue)
        {
            var chars = inputValue.ToCharArray();
            var productList = new List<long>();

            for (int i = 0; i <= chars.Length - adjacentChars; i++)
            {
                long product = 1;

                for (int j = 0; j < adjacentChars; j++)
                {
                    var value = chars.ElementAt(i + j);
                    product *= int.Parse(value.ToString());
                }

                productList.Add(product);
            }
            return productList.Max();
        }
        #endregion

        #region Question9
        public int PythagoreanTriplet(int sideSum)
        {
            for (int a = 1; a < sideSum; a++)
            {
                var b = a;
                var c = 0.0;

                do
                {
                    b++;
                    var cSquared = a*a + b*b;
                    c = Math.Sqrt(cSquared);
                } while (a+b+c < sideSum);

                if (a+b+c == sideSum)
                {
                    return (a * b * Convert.ToInt32(c));
                }
            }

            return 0;
        }
        #endregion

        //TODO: Questions 10-12

        #region Question13
        public long LargeSum(IList<string> numbers, int digits)
        {
            long sum = 0;

            foreach (var item in numbers)
            {
                var checkLength = 0;

                if (item.Length <= digits + 3)
                    checkLength = item.Length;
                else
                    checkLength = digits + 3;

                var truncVal = item.Substring(0, checkLength);

                sum += long.Parse(truncVal);
            }

            var stringSum = sum.ToString();

            return long.Parse(stringSum.Substring(0, digits));
        }
        #endregion

        #region Question14
        public int LongestCollatzSequence(int maxValue, int minValue)
        {
            var mostSteps = 0;
            var stepValue = 0;

            for (int i = maxValue; i >= minValue; i--)
            {
                var steps = GetCollatzSteps(i);

                if (steps > mostSteps)
                {
                    mostSteps = steps;
                    stepValue = i;
                }
            }
            return stepValue;
        }

        private int GetCollatzSteps(int value)
        {
            var totalSteps = 0;
            long currValue = value;

            for (int s = 1; currValue > 1; s++)
            {
                currValue = (currValue % 2 == 0) ? DoEven(currValue) : DoOdd(currValue);
                totalSteps = s;
            }
            return totalSteps;
        }

        private long DoEven(long value)
        {
            return value/2;
        }

        private long DoOdd(long value)
        {
            return 3 * value + 1;
        }
        #endregion

        #region Question15

        #endregion
    }
}
