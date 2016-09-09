using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPP_Dive_into_IL;

namespace SPP_Dive_into_IL.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        QuickSort sut;

        [TestInitialize]
        public void TestSetUp()
        {
            sut = new QuickSort();
        }

        [TestMethod]
        public void CheckLengthOfInitMass()
        {
            int[] result = sut.GenerateRandomMass(10);

            Assert.AreEqual(10, result.Length);
        }
    }
}
