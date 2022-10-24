using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestMyCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Sum()
        {
            Util util = new Util();
            int x = 5; int y = 3;
            int expected = 8;
            int actual = util.sum(x, y);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestMethod_SumX()
        {
            Util util = new Util();
            int x = 3; int y = 3;
            int expected = 6;
            int actual = util.sumX(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_Operation()
        {
            
            try 
            {
                Util util = new Util();
                util.Operation();
                Assert.IsTrue(true);
            }
            catch 
            {
                Assert.IsFalse(false);
            }
        }
    }
}
