using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciNumbersWithInput.Properties;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciNumbersWithInputUnitTest
{
    [TestClass]
    public class FebonacciSequenceTest
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void OneOfTheNumbersIsLessThanZero()
        {
            Febonacci f = new Febonacci(-1, 1, 1);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void OneOfTheNumbersIsNotFebonacci()
        {
            Febonacci f = new Febonacci(1, 15, 1);
        }


        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void MaximumNumberIsZero()
        {
            Febonacci f = new Febonacci(1, 15, 0);
        }

        [TestMethod]
        public void FebonacciSequenceCount()
        {
            Febonacci f = new Febonacci(1, 1, 5);
            List<BigInteger> actualList = f.CalculateAndDisplaySequence();

            List<BigInteger> expectedList = new List<BigInteger>() { 1, 1, 2, 3, 5, 8,13 };

            Assert.IsTrue(expectedList.SequenceEqual(actualList));

        }



    }
}
