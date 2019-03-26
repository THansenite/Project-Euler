using System;
using Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionTests
{
    [TestClass]
    public class Problem003Tests
    {
        private SolutionLogic _problem3;

        [TestInitialize]
        public void Initialize()
        {
            _problem3 = new SolutionLogic();
        }

        [TestMethod]
        public void NoValues()
        {
            var result = RunProblem(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void PrimeValuePassedIn()
        {
            var result = RunProblem(5);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SmallValue_SinglePrimeFactor()
        {
            var result = RunProblem(9);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SmallValue_MultiplePrimeFactos()
        {
            var result = RunProblem(15);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MediumValue_MultiplePrimeFactos()
        {
            var result = RunProblem(81);

            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void EulerExample()
        {
            var result = RunProblem(13195);

            Assert.AreEqual(2639, result);
        }
        
        private long RunProblem(long maxValue)
        {
            return _problem3.LargestPrimeFactor(maxValue);
        }
    }
}
