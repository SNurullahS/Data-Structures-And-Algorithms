using System;
using Data_Structures_And_Algorithms;
using Data_Structures_And_Algorithms.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;  

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
         GMethods gMethods = new GMethods();
        DublicateSolver Ds = new DublicateSolver();
        SingleNumber SN = new SingleNumber();   
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


        [TestMethod]
        public void TestIsDuplicateWithDuplicates()
        {
            int[] duplicates = { 1, 2, 2, 3, 4, 4, 5 };
            bool result = Ds.isDuplicate(duplicates);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsDuplicateWithoutDuplicates()
        {
            int[] noDuplicates = { 1, 2, 3, 4, 5 };
            bool result = Ds.isDuplicate(noDuplicates);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestFindUniqueNumberWithDuplicates()
        {
            int[] numbers = { 1, 2, 2, 3, 3, 4, 4 };

            int uniqueNumber = SN.FindUniqueNumber(numbers);

            Assert.AreEqual(1, uniqueNumber);
        }

        [TestMethod]
        public void STestFindUniqueNumberWithDuplicates()
        {
            int[] numbers = { 1, 2, 2, 3, 3, 4, 4 };

            int uniqueNumber = SN.FindUniqueNumber(numbers);

            Assert.AreEqual(1, uniqueNumber);
        }

        [TestMethod]
        public void TestFindUniqueNumberWithoutDuplicates()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int uniqueNumber = SN.FindUniqueNumber(numbers);

            Assert.AreEqual(1, uniqueNumber);
        }


    }
}
