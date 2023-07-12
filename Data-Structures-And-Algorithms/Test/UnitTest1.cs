using System;
using Data_Structures_And_Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;  

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Factorial_ReturnsCorrectResult()
        {
            GMethods gMethods = new GMethods();
            // Arrange
            int number = 5;
            int expectedFactorial = 120;

            // Act
            int result = gMethods.Factorial(number);

            // Assert
            Assert.AreEqual(expectedFactorial, result);
        }

    }
}
