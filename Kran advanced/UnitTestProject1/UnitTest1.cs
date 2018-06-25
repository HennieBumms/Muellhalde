using System;
using System.Windows.Forms;
using ClassLibrary1;
using Kran_advanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {


        [TestMethod]
        public void HakenEinTest() {
            // arrange
            Kran kran = new Kran();
            Panel haken = new Panel();
            haken.Size = new System.Drawing.Size(0,0);

            // act
            kran.HakenEin(haken);

            // assert
            Assert.AreEqual(10, haken.Size.Height);

        }

        [TestMethod]
        public void HakenAusTest() {
            // arrange
            Kran kran = new Kran();
            Panel haken = new Panel();
            haken.Size = new System.Drawing.Size(0, 0);

            // act
            kran.HakenAus(haken);

            // assert
            Assert.AreEqual(-10, haken.Size.Height);
        }

        [TestMethod]
        public void ArmEinTest() {
            // arrange
            Kran kran = new Kran();
            Panel haken = new Panel();
            Panel arm = new Panel();
            haken.Size = new System.Drawing.Size(0, 0);
            haken.Location = new System.Drawing.Point(20, 20);
            arm.Size = new System.Drawing.Size(50, 50);
            arm.Location = new System.Drawing.Point(10, 10);

            // act
            kran.ArmEin(arm, haken);

            // assert
            Assert.AreEqual(30, haken.Location.X);
            Assert.AreEqual(20, haken.Location.Y);
            Assert.AreEqual(40, arm.Size.Width);
            Assert.AreEqual(50, arm.Size.Height);
            Assert.AreEqual(20, arm.Location.X);
            Assert.AreEqual(10, arm.Location.Y);
        }

        [TestMethod]
        public void ArmAusTest() {
            // arrange
            Kran kran = new Kran();
            Panel haken = new Panel();
            Panel arm = new Panel();
            haken.Size = new System.Drawing.Size(0, 0);
            haken.Location = new System.Drawing.Point(20, 20);
            arm.Size = new System.Drawing.Size(50, 50);
            arm.Location = new System.Drawing.Point(10, 10);

            // act
            kran.ArmAus(arm, haken);

            // assert
            Assert.AreEqual(10, haken.Location.X);
            Assert.AreEqual(20, haken.Location.Y);
            Assert.AreEqual(60, arm.Size.Width);
            Assert.AreEqual(50, arm.Size.Height);
            Assert.AreEqual(0, arm.Location.X);
            Assert.AreEqual(10, arm.Location.Y);
        }

        [TestMethod]
        public void BasiLinksTest() {
            // arrange
            Kran kran = new Kran();

            Panel haken = new Panel();
            haken.Size = new System.Drawing.Size(0, 0);
            haken.Location = new System.Drawing.Point(20, 20);

            Panel arm = new Panel();
            arm.Size = new System.Drawing.Size(50, 50);
            arm.Location = new System.Drawing.Point(10, 10);

            Panel basi = new Panel();
            basi.Size = new System.Drawing.Size(50, 50);
            basi.Location = new System.Drawing.Point(50, 50);

            Panel high = new Panel();
            high.Size = new System.Drawing.Size(100, 10);
            high.Location = new System.Drawing.Point(10, 10);

            // act
            kran.BasiLinks(basi, arm, haken, high);

            // assert
            Assert.AreEqual(10, haken.Location.X);
            Assert.AreEqual(20, haken.Location.Y);
            Assert.AreEqual(0, arm.Location.X);
            Assert.AreEqual(10, arm.Location.Y);
            Assert.AreEqual(40, basi.Location.X);
            Assert.AreEqual(50, basi.Location.Y);
            Assert.AreEqual(0, high.Location.X);
            Assert.AreEqual(10, high.Location.Y);

        }

        [TestMethod]
        public void BasiRechtsTest() {
            // arrange
            Kran kran = new Kran();

            Panel haken = new Panel();
            haken.Size = new System.Drawing.Size(0, 0);
            haken.Location = new System.Drawing.Point(20, 20);

            Panel arm = new Panel();
            arm.Size = new System.Drawing.Size(50, 50);
            arm.Location = new System.Drawing.Point(10, 10);

            Panel basi = new Panel();
            basi.Size = new System.Drawing.Size(50, 50);
            basi.Location = new System.Drawing.Point(50, 50);

            Panel high = new Panel();
            high.Size = new System.Drawing.Size(100, 10);
            high.Location = new System.Drawing.Point(10, 10);

            // act
            kran.BasiRechts(basi, arm, haken, high);

            // assert
            Assert.AreEqual(30, haken.Location.X);
            Assert.AreEqual(20, haken.Location.Y);
            Assert.AreEqual(20, arm.Location.X);
            Assert.AreEqual(10, arm.Location.Y);
            Assert.AreEqual(60, basi.Location.X);
            Assert.AreEqual(50, basi.Location.Y);
            Assert.AreEqual(20, high.Location.X);
            Assert.AreEqual(10, high.Location.Y);

        }

        [TestMethod]
        public void KranAusTest() {
            // arrange
            Kran kran = new Kran();

            Panel haken = new Panel();
            haken.Size = new System.Drawing.Size(0, 0);
            haken.Location = new System.Drawing.Point(20, 20);

            Panel arm = new Panel();
            arm.Size = new System.Drawing.Size(50, 50);
            arm.Location = new System.Drawing.Point(10, 10);

            Panel basi = new Panel();
            basi.Size = new System.Drawing.Size(50, 50);
            basi.Location = new System.Drawing.Point(50, 50);

            Panel high = new Panel();
            high.Size = new System.Drawing.Size(100, 10);
            high.Location = new System.Drawing.Point(10, 10);

            // act
            kran.KranAus(basi, arm, haken, high);

            // assert
            Assert.AreEqual(20, haken.Location.X);
            Assert.AreEqual(10, haken.Location.Y);
            Assert.AreEqual(10, arm.Location.X);
            Assert.AreEqual(0, arm.Location.Y);
            Assert.AreEqual(50, basi.Location.X);
            Assert.AreEqual(50, basi.Location.Y);
            Assert.AreEqual(10, high.Location.X);
            Assert.AreEqual(0, high.Location.Y);
            Assert.AreEqual(20, high.Height);
            Assert.AreEqual(100, high.Width);

        }

        [TestMethod]
        public void KranEinTest() {
            // arrange
            Kran kran = new Kran();

            Panel haken = new Panel();
            haken.Size = new System.Drawing.Size(0, 0);
            haken.Location = new System.Drawing.Point(20, 20);

            Panel arm = new Panel();
            arm.Size = new System.Drawing.Size(50, 50);
            arm.Location = new System.Drawing.Point(10, 10);

            Panel basi = new Panel();
            basi.Size = new System.Drawing.Size(50, 50);
            basi.Location = new System.Drawing.Point(50, 50);

            Panel high = new Panel();
            high.Size = new System.Drawing.Size(100, 10);
            high.Location = new System.Drawing.Point(10, 10);

            // act
            kran.KranEin(basi, arm, haken, high);

            // assert
            Assert.AreEqual(20, haken.Location.X);
            Assert.AreEqual(30, haken.Location.Y);
            Assert.AreEqual(10, arm.Location.X);
            Assert.AreEqual(20, arm.Location.Y);
            Assert.AreEqual(50, basi.Location.X);
            Assert.AreEqual(50, basi.Location.Y);
            Assert.AreEqual(10, high.Location.X);
            Assert.AreEqual(20, high.Location.Y);
            Assert.AreEqual(0, high.Height);
            Assert.AreEqual(100, high.Width);

        }
    }
}
