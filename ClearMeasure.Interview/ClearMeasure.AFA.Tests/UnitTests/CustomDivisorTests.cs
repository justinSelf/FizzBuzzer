using System;
using ClearMeasure.AFA.DivisorStrategies;
using FluentAssertions;
using NUnit.Framework;

namespace ClearMeasure.AFA.Tests.UnitTests
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
            result.Should().BeTrue();
        }

        [Test]
        public void ShouldCallTheSuppliedFactorFunction()
        {
            //Arrange
            var suppliedFactorFunctionWasCalled = false;

            Func<decimal, bool> badFactorFunc = num => suppliedFactorFunctionWasCalled = true;
            
            var divisor = new CustomDivisor("", badFactorFunc);

            //Act
            var message = divisor.IsFactorOf(9);

            //Assert
            message.Should().BeTrue();
        }
    }
}
