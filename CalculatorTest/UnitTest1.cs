using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        public TestContext TestContext { get; set; }
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
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            Calculation c;
            int a, b, expected;
            string operation ;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();//'-
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Calculation(a, b);
            Assert.AreEqual(expected, c.Execute(operation));
        }
        [TestMethod]
        public void TestSoSanh()
        {
            
            int a, b, r;
            a = 2;
            b = 3;
            Calculation c = new Calculation(a,b);
            r = c.Sosanh(a, b);
            Assert.AreEqual(1, r);
        }
    }
}
