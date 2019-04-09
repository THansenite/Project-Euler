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
    public class Problem009Tests
    {
        private SolutionLogic _problem9;

        [TestInitialize]
        public void Initialize()
        {
            _problem9 = new SolutionLogic();
        }

        [TestMethod]
        public void ZeroPassedIn()
        {
            var result = RunProblem(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EulerExample()
        {
            var result = RunProblem(12);

            Assert.AreEqual(60, result);
        }

        private int RunProblem(int sideSum)
        {
            return _problem9.PythagoreanTriplet(sideSum);
        }
    }
}
