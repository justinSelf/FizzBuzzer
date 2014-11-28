using System;
using ClearMeasure.AFA.DivisorStrategies;
using FluentAssertions;
using NUnit.Framework;

namespace ClearMeasure.AFA.Tests
{
    [TestFixture]
    public class CustomDivisorTests
    {
        [Test]
        public void CustomDivisorShouldWork()
        {
            //Arrange
            var divisor = new CustomDivisor(3, "");

            //Act
            var result = divisor.IsFactorOf(9);

            //Assert
            result.Should().BeTrue("3 is a factor of 9");
        }

        [Test]
        public void ShouldCallTheSuppliedFactorFunction()
        {
            //Arrange
            var suppliedFunctionWasCalled = false;
            Func<long, bool> badFactorFunc = num => suppliedFunctionWasCalled = true;

            var divisor = new CustomDivisor(3, "", badFactorFunc);

            //Act
            divisor.IsFactorOf(9);

            //Assert
            suppliedFunctionWasCalled.Should().BeTrue("the supplied factor function should have been called.");
        }
    }
}
