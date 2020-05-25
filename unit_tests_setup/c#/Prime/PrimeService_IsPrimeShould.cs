using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNUnit
{

    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        #region Sample_TestCode
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
        #endregion

        [Test]
        public void SmallPrimes()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            for (var i = 0; i < numbers.Length; i++)
            {
                Assert.IsTrue(_primeService.IsPrime(numbers[i]));
            }

        }

        [Test]
        public void Negatives()
        {
            int[] numbers = { -2, -3, -5, -7, -11, -13, -17};

            for (var i = 0; i < numbers.Length; i++)
            {
                Assert.IsFalse(_primeService.IsPrime(numbers[i]));
            }
        }

        [Test]
        public void PositiveNotPrime()
        {
            int[] numbers = { 4, 6, 8, 9 };

            for (var i = 0; i < numbers.Length; i++)
            {
                Assert.IsFalse(_primeService.IsPrime(numbers[i]));
            }
        }

        [Test]
        public void ZeroAndOne()
        {
            Assert.IsFalse(_primeService.IsPrime(0));
            Assert.IsFalse(_primeService.IsPrime(1));
        }
    }
}
