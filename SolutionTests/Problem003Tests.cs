using System;
using Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionTests
{
    [TestClass]
    public class Problem003Tests
    {
        private Problem003 _problem3;

        [TestInitialize]
        public void Initialize()
        {
            _problem3 = new Problem003();
        }

        [TestMethod]
        public void NoValues()
        {
            var result = RunProblem(0);

            Assert.AreEqual(0, result);
        }

        public void SmallValue()
        {
            var result = RunProblem(10);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Example()
        {
            var result = RunProblem(13195);

            Assert.AreEqual(29, result);
        }

        private int RunProblem(int maxValue)
        {
            return _problem3.LargestPrimeFactor(maxValue);
        }
    }
}
