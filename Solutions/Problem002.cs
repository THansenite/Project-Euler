using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem002
    {
        public int EvenFibonacci(int maxValue)
        {
            var previous = 1;
            var current = 2;
            var result = 0;

            while (current <= maxValue)
            {
                if (current%2 == 0)
                    result += current;

                var newFib = previous + current;
                previous = current;
                current = newFib;
            }

            return result;
        }
    }
}
