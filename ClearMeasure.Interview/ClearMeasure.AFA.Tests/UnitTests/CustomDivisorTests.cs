using System;
using ClearMeasure.AFA.DivisorStrategies;
using FluentAssertions;
using NUnit.Framework;

namespace ClearMeasure.AFA.Tests.UnitTests
{
    [TestFixture]
    public class CustomDivisorTests
    {
        const string FUNC_MESSAGE = "I'm a message";
        [Test]
        public void CustomDivisorShouldWork()
        {
            //Arrange
            var divisor = new CustomDivisor(3, FUNC_MESSAGE);

            //Act
            var result = divisor.GetMessageForFactorOf(9);

            //Assert
            result.Should().Be(FUNC_MESSAGE);
        }

        [Test]
        public void ShouldCallTheSuppliedFactorFunction()
        {
            //Arrange
            Func<long, string> badFactorFunc = num => FUNC_MESSAGE;

            var divisor = new CustomDivisor(3, "", badFactorFunc);

            //Act
            var message = divisor.GetMessageForFactorOf(9);

            //Assert
            message.Should().Be(FUNC_MESSAGE);
        }
    }
}
