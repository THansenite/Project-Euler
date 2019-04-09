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
    public class Problem013Tests
    {
        private SolutionLogic _problem13;

        [TestInitialize]
        public void Initialize()
        {
            _problem13 = new SolutionLogic();
        }

        [TestMethod]
        public void EmptySet()
        {
            var result = RunProblem(new List<string>(), 1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SimpleTest()
        {
            var testSet = new List<string>(){ "1", "2", "3"};
            var result = RunProblem(testSet, 1);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void LargeNumbers()
        {
            var testSet = new List<String>
            {
                "37107287533902102798797998220837590246510135740250",
                "46376937677490009712648124896970078050417018260538",
                "74324986199524741059474233309513058123726617309629",
            };
            var result = RunProblem(testSet, 10);

            Assert.AreEqual(1578092114, result);
        }

        private long RunProblem(IList<string> inputNumbers, int digits)
        {
            return _problem13.LargeSum(inputNumbers, digits);
        }
    }
}
