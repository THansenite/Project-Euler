using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionTests
{
    [TestClass]
    public class Problem006Tests
    {
        private SolutionLogic _sl6;

        [TestInitialize]
        public void Initialize()
        {
            _sl6 = new SolutionLogic();
        }

        [TestMethod]
        public void ZeroTest()
        {
            var result = ExecuteLogic(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EulerExample()
        {
            var result = ExecuteLogic(10);
            Assert.AreEqual(2640, result);
        }

        private int ExecuteLogic(int value)
        {
            return _sl6.SumSquareDifference(value);
        }
    }
}
