using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem003
    {
        public int LargestPrimeFactor(long value)
        {
            var largestPrime = 0;

            for (long i = 2; i < value; i++)
            {
                if (DividesEvenly(value, i))
                {
                    // This gets all 'i' that divide evenly into the original value
                    // Need to check if that 'i' is prime or not

                }
            }

            return largestPrime;
        }

        private bool DividesEvenly(long dividend, long divisor)
        {
            return dividend % divisor == 0;
        }
    }
}
