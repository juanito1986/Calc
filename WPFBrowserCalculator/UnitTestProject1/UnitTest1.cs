using System;
using System.Windows;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOperationPlus()
        {
            Assert.AreEqual("14", Calculator.EvaluateExpression("1 + 13"));
        }

        [TestMethod]
        public void TestOperationMinus()
        {
            Assert.AreEqual("-12", Calculator.EvaluateExpression("1 - 13"));
        }

        [TestMethod]
        public void TestOperationDividedBy()
        {
            Assert.AreEqual("12", Calculator.EvaluateExpression("24 / 2"));
        }

        [TestMethod]
        public void TestOperationFor()
        {
            Assert.AreEqual("24", Calculator.EvaluateExpression("12 * 2"));
        }

    }
}
