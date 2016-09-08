using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPP_Dive_into_IL;

namespace SPP_Dive_into_IL.Tests
{
    [TestClass]
    public class ComparerTest
    {
        Comparer sut;

        [TestInitialize]
        public void TestSetUp()
        {
            sut = new Comparer();
        }

        [TestMethod]
        public void CheckCompareEqualElements()
        {
            int result = sut.Compare(9, 9);

            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void CheckCompareMoreWithLess()
        {
            int result = sut.Compare(10, 3);

            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void CheckCompareLessWithMore()
        {
            int result = sut.Compare(5, 40);

            Assert.AreEqual(-1, result);

        }
    }
}
