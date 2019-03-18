using System;
using Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionTests
{
    [TestClass]
    public class Problem001Tests
    {
        private Problem001 _problem1;

        [TestInitialize]
        public void Initialize()
        {
            _problem1 = new Problem001();
        }

        [TestMethod]
        public void NoIterations()
        {
            var iterations = 0;

            int result = _problem1.MultiplesOf3and5(iterations);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TenIterations()
        {
            var iterations = 10;

            int result = _problem1.MultiplesOf3and5(iterations);

            Assert.AreEqual(23, result);
        }
    }
}
