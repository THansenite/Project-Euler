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
            
            Assert.AreEqual(0, RunProblem(maxValue));
        }

        [TestMethod]
        public void First10()
        {
            var maxValue = 90;

            Assert.AreEqual(44, RunProblem(maxValue));
        }

        private int RunProblem(int maxValue)
        {
            return (_problem2.EvenFibonacci(maxValue));
        }
    }
}
