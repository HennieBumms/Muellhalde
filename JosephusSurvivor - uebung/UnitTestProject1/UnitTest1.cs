using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Josephus;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Tests()
        {
            Console.WriteLine("Basic Tests JosSurvivor");
            Assert.AreEqual(4,JosephusSurvivor.JosSurvivor(7, 3));
            Assert.AreEqual(10,JosephusSurvivor.JosSurvivor(11, 19));
            Assert.AreEqual(28, JosephusSurvivor.JosSurvivor(40, 3));
            Assert.AreEqual(13, JosephusSurvivor.JosSurvivor(14, 2));
            Assert.AreEqual(100, JosephusSurvivor.JosSurvivor(100, 1));
            Assert.AreEqual(1, JosephusSurvivor.JosSurvivor(1, 300));
            Assert.AreEqual(1, JosephusSurvivor.JosSurvivor(2, 300));
            Assert.AreEqual(1, JosephusSurvivor.JosSurvivor(5, 300));
            Assert.AreEqual(7, JosephusSurvivor.JosSurvivor(7, 300));
            Assert.AreEqual(265, JosephusSurvivor.JosSurvivor(300, 300));
        }
    }
}
