using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Unit_Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [Owner("Vivek_Arya")]
        [TestCategory("Calculator_Test_Main")]
        [TestCategory("Calculator_Test_2")]
        [TestProperty("Test_Group","Divide_Functionality_For_Zero")]
        [Priority(1)]
        public void TestDivide()
        {
            //arrange section:
            int expected = 5;
            int numerator = 10;
            int denominator = 2;

            //Act
            int actual=Calculator_MSTest_Framework.Calculator.Divide(numerator,denominator);

            //Assert
            Assert.AreEqual(expected,actual);

        }


        [TestMethod]
        [TestCategory("Calculator_Test_Main")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            int numerator = 20;
            int denominator = 0;
            try
            {
                Calculator_MSTest_Framework.Calculator.Divide(numerator,denominator);
            }
            catch(DivideByZeroException exec)
            {
                Assert.AreEqual("Cannot divide by 0", exec.Message);
                throw;//this line is vvvvv important
            }
        }
    }
}
