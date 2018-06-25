using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {            
            var datei = new Datei();
            Button button = new Button();

            Form1 form = new Form1();
            form.button1_Click(button, new EventArgs());

            Assert.AreEqual("bla", button.Text);
        }
    }
}
