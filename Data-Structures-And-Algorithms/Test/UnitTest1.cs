using System;
using Data_Structures_And_Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;  

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
         GMethods gMethods = new GMethods();
       
        [TestMethod]
        public void Factorial_ReturnsCorrectResult()
        {
            // Arrange
            int number = 5;
            int expectedFactorial = 120;

            // Act
            int result = gMethods.Factorial(number);

            // Assert
            Assert.AreEqual(expectedFactorial, result);
        }

        [TestMethod]
        public void Guess_ReturnsMiddleNumber()
        {
            // Arrange
            int minNumber = 1;
            int maxNumber = 10;
            int expectedGuess = 5;

            // Act
            int result = gMethods.Guess(minNumber, maxNumber);

            // Assert
            Assert.AreEqual(expectedGuess, result);
        }
    }
}
