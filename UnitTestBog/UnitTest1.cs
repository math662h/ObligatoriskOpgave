using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;

namespace UnitTestBog
{
    [TestClass]
    public class UnitTest1
    {
        private Bog b;
        [TestInitialize]
        public void TestStart()
        {
             b = new Bog("Ee","Poul Henning",788,"123456789asxj");
       
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestTitelFail()
        {
            b.Titel = "E";
        }
        [TestMethod]
        public void TestTitelSucces()
        {
            b.Titel = "oj";
            Assert.AreEqual("oj", b.Titel);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSidetalFailHigh()
        {
            b.Sidetal = 1001;
            
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSidetalFailLow()
        {
            b.Sidetal = 2;

        }
        [TestMethod]
        public void TestSidetalSucces()
        {
            b.Sidetal = 222;
            Assert.AreEqual(222, b.Sidetal);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestIsbnFailLow()
        {
            b.Isbn13 = "jjjejgjgiej";
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestIsbnFailHigh()
        {
            b.Isbn13 = "jjjejgjgiejsssssssss";
        }

        [TestMethod]
        public void TestIsbnSucces()
        {
            b.Isbn13 = "jhjhjhslkjdhj";
            Assert.AreEqual("jhjhjhslkjdhj", b.Isbn13);
        }
        /*[ExpectedException(typeof(Bog))]
        [TestMethod]
        public void TestConstructorSucces()
        {
            Bog bog = new Bog("Hej", "Oliver", 860, "1234567890120");
            Assert.IsTrue(bog.GetType() == typeof(Bog));
        }
       */
    }
}
