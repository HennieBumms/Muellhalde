using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListeInListe;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            string[] a1 = new string[] { "arp", "mice", "bull" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp" };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong", "codewars" };
            string[] r = new string[] { "cod", "code", "ewar", "wars" };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [TestMethod]
        public void TestMethod4()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar", "ar" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong", "codewars" };
            string[] r = new string[] { "ar", "cod", "code", "ewar", "wars" };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [TestMethod]
        public void TestMethod5()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar", "ar" };
            string[] a2 = new string[] { };
            string[] r = new string[] { };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [TestMethod]
        public void TestMethod6()
        {
            string[] a1 = new string[] { "1295", "code", "1346", "1028", "ar" };
            string[] a2 = new string[] { "12951295", "ode", "46", "10281066", "par" };
            string[] r = new string[] { "1028", "1295", "ar" };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [TestMethod]
        public void TestMethod7()
        {
            string[] a1 = new string[] { "&()", "code", "1346", "1028", "ar" };
            string[] a2 = new string[] { "12&()95", "coderange", "46", "1066", "par" };
            string[] r = new string[] { "&()", "ar", "code" };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [TestMethod]
        public void TestMethod8()
        {
            string[] a1 = new string[] { "ohio", "code", "1346", "1028", "art" };
            string[] a2 = new string[] { "Carolina", "Ohio", "4600", "NY", "California" };
            string[] r = new string[] { };
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }
}
