using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            cal = new Calculator.Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void TestSubOperator()
        {

            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOperator()
        {

            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivideOperator()
        {

            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            Calculation c = new Calculator.Calculation(10, 0);
            c.Execute("/");
        }
    }
}
