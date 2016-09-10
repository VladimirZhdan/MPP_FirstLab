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

        [TestMethod]
        public void CheckRightSortMass()
        {
            int[] mass = sut.GenerateRandomMass(100);
            sut.SortMass(mass);

            bool result = true;
            for(int i = 0; (i < mass.Length - 1) && (result); i++)
            {
                if (mass[i] > mass[i + 1])
                    result = false;
            }

            Assert.AreEqual(true, result);
        }
    }
}
