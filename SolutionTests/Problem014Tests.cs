using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTests
{
    [TestClass]
    public class Problem014Tests
    {
        private SolutionLogic _problem14;

        [TestInitialize]
        public void Initialize()
        {
            _problem14 = new SolutionLogic();
        }

        [TestMethod]
        public void Zero()
        {
            var result = RunProblem(0, 0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SimpleSmallTest()
        {
            var result = RunProblem(8, 1);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void EulerExample()
        {
            var result = RunProblem(13, 13);

            Assert.AreEqual(13, result);
        }

        private int RunProblem(int maxValue, int minValue)
        {
            return _problem14.LongestCollatzSequence(maxValue, minValue);
        }
    }
}
