using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        [TestInitialize]
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {//10 + 5 = 15
            Assert.AreEqual(15,c.Execute("+"));
        }
        [TestMethod]
        public void TestTruOperator()
        {//10 - 5 = 5
            Assert.AreEqual(5, c.Execute("-"));
        }
        [TestMethod]
        public void TestNhanOperator()
        {//10 - 5 = 5
      
            Assert.AreEqual(50, c.Execute("*"));
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestChiaOperator()
        {//10 - 5 = 5
            c = new Calculation(10, 0);
            c.Execute("/");
        }
    }
}
