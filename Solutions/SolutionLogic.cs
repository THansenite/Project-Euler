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
    }
}
