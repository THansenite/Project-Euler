using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionTests
{
    [TestClass]
    public class Problem002Tests
    {
        private Problem002 _problem2;

        [TestInitialize]
        public void Initialize()
        {
            _problem2 = new Problem002();
        }

        [TestMethod]
        public void NoNumbers()
        {
            var maxValue = 0;

            var result = _problem2.EvenFibonacci(maxValue);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void First10()
        {
            var maxValue = 90;

            var result = _problem2.EvenFibonacci(maxValue);

            Assert.AreEqual(44, result);
        }
    }
}
