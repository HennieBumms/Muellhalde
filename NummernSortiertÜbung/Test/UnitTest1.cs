using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NummernSortiert;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = new int[] { 1, 4, 13, 97, 508, 1047, 20058 };
            bool result = true;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = new int[] { 56, 98, 123, 67, 742, 1024, 32, 90969 };
            bool result = false;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = new int[] { 1, 2 };
            bool result = true;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] arr = new int[] { 2, 1 };
            bool result = false;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] arr = new int[] { 1, 2, 3 };
            bool result = true;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] arr = new int[] { 1, 3, 2 };
            bool result = false;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod7()
        {
            int[] arr = new int[] { 2, 1, 3 };
            bool result = false;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod8()
        {
            int[] arr = new int[] { 2, 3, 1 };
            bool result = false;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod9()
        {
            int[] arr = new int[] { 3, 1, 2 };
            bool result = false;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
        [TestMethod]
        public void TestMethod10()
        {
            int[] arr = new int[] { 3, 2, 1 };
            bool result = false;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }

        [TestMethod]
        public void TestMethod11()
        {
            int[] arr = new int[] { };
            bool result = true;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }

        [TestMethod]
        public void TestMethod12()
        {
            int[] arr = new int[] {5};
            bool result = true;

            Assert.AreEqual(result, Nummern.IstSortiert(arr));
        }
    }
}
