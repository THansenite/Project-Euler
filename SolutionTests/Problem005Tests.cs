using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionTests
{
    [TestClass]
    public class Problem005Tests
    {
        private SolutionLogic _sl5;

        [TestInitialize]
        public void Initialize()
        {
            _sl5 = new SolutionLogic();
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
            var result = ExecuteLogic(10);

            Assert.AreEqual(2520, result);
        }

        private int ExecuteLogic(int maxDivisor)
        {
            return _sl5.SmallestMultiple(maxDivisor);
        }
    }
}
