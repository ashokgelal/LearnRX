using System.Collections.Generic;
using System.Linq;
using LearnRx.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace LearnRx.Tests
{
    [TestClass]
    public class ArrayTraversing
    {
        [TestMethod]
        public void TestPrintNames()
        {
            var logger = Substitute.For<ILogger>();
            var names = new List<string>();
            logger.Log(Arg.Do<object>(e=> names.Add(e.ToString())));
            LearnRx.ArrayTraversing.PrintNames(logger);
            Assert.AreEqual(8, names.Count);
            Assert.IsTrue(names.SequenceEqual(new[] {"Ben", "Adam", "Mike", "Billy", "Jacob", "Zach", "Kevin", "Vanessa"}));
        }
    }
}
