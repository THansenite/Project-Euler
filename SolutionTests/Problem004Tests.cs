using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionTests
{
    [TestClass]
    public class Problem004Tests
    {
        private SolutionLogic _sl4;

        [TestInitialize]
        public void Initialize()
        {
            _sl4 = new SolutionLogic();
        }

        [TestMethod]
        public void ZeroDigits()
        {
            var result = ExecuteLogic(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EulerExample()
        {
            var result = ExecuteLogic(99);

            Assert.AreEqual(9009, result);
        }

        private int ExecuteLogic(int digits)
        {
            return _sl4.LargestPalendromeFactor(digits);
        }
    }
}
