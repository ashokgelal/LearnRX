using System.Collections.Generic;
using System.Linq;
using LearnRx.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace LearnRx.Tests
{
    [TestClass]
    public class ArrayTraversingTest
    {
        [TestMethod]
        public void TestPrintNames()
        {
            var logger = Substitute.For<ILogger>();
            var names = new List<string>();
            logger.Log(Arg.Do<object>(e => names.Add(e.ToString())));
            ArrayTraversing.PrintNames(logger);
            Assert.AreEqual(ArrayTraversing.Names.Count(), names.Count);
            Assert.IsTrue(names.SequenceEqual(ArrayTraversing.Names));
        }

        [TestMethod]
        public void TestPrintNamesForEach()
        {
            var logger = Substitute.For<ILogger>();
            var names = new List<string>();
            logger.Log(Arg.Do<object>(e => names.Add(e.ToString())));
            ArrayTraversing.PrintNamesForEach(logger);
            Assert.AreEqual(ArrayTraversing.Names.Count(), names.Count);
            Assert.IsTrue(names.SequenceEqual(ArrayTraversing.Names));
        }
    }
}
