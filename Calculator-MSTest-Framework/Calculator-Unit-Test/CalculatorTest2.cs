using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Unit_Test
{
    [TestClass]
    public class CalculatorTest2
    {
        [TestMethod]
        [Owner("Vivek_Arya")]
        [TestCategory("Calculator_Test_2")]
        [TestProperty("Test_Group", "Divide_Functionality")]
        [Priority(2)]
        public void TestMethodForZero()
        {
            int numerator = 0;
            int denominator = 1;
            int expected = 0;
            int result = Calculator_MSTest_Framework.Calculator.Divide(numerator,denominator);
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        [Owner("Vivek_Arya")]
        [TestCategory("Calculator_Test_2")]
        public void MyTestMethod()
        {
            PrivateType p = new PrivateType(typeof(Calculator_MSTest_Framework.Calculator));
            bool result=(bool)p.InvokeStatic("isPositive",10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Vivek_Arya")]
        [TestCategory("Calculator_Test_2")]
        public void MyTestMethodNonStatic()
        {
            PrivateObject p = new PrivateObject(typeof(Calculator_MSTest_Framework.Calculator));
            bool result=(bool)p.Invoke("instanceIsPositive", -10);
            Assert.IsFalse(result);
        }
        

    }
}
