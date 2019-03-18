using System;
using Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionTests
{
    [TestClass]
    public class Problem001Tests
    {
        private SolutionLogic _logic;

        [TestInitialize]
        public void Initialize()
        {
            _logic = new SolutionLogic();
        }

        [TestMethod]
        public void NoIterations()
        {
            var iterations = 0;

            int result = _logic.MultiplesOf3and5(iterations);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TenIterations()
        {
            var iterations = 10;

            int result = _logic.MultiplesOf3and5(iterations);

            Assert.AreEqual(23, result);
        }
    }
}
