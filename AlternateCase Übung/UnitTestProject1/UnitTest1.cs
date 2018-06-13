using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            String value = "Test";
            String expected = "tEST";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            String value = "HELLO WORLD";
            String expected = "hello world";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            String value = "hello world";
            String expected = "HELLO WORLD";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            String value = "HELLO world";
            String expected = "hello WORLD";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            String value = "hEllO wOrld";
            String expected = "HeLLo WoRLD";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            String value = "12345";
            String expected = "12345";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            String value = "Test";
            String expected = "tEST";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            // Arrange
            String value = "1A2B3C4D5E";
            String expected = "1a2b3c4d5e";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            // Arrange
            String value = "sTRING.tOaLTERNATINGcASE";
            String expected = "String.ToAlternatingCase";
            String result;

            // Act
            result = UseWriter(value);

            //Assert
            Assert.AreEqual(expected, result);
        }        

        private string UseWriter(string value)
        {
            string result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                AlternateCase.AlternateCaseWriter writer = new AlternateCase.AlternateCaseWriter(memoryStream);                
                writer.Write(value);
                writer.Flush();
                memoryStream.Position = 0;
                StreamReader sr = new StreamReader(memoryStream);
                result = sr.ReadToEnd();
            }

            return result;
        }
    }    
}
