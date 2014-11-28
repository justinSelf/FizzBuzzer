using System.Collections;
using System.Collections.Generic;
using System.Text;
using ClearMeasure.AFA.DivisorStrategies;
using ClearMeasure.AFA.DivisorStrategies.Interfaces;
using ClearMeasure.AFA.Writers;
using ClearMeasure.AFA.Writers.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace ClearMeasure.AFA.Tests.IntergrationTests
{
    [TestFixture]
    public class Using3And5andDefaultStrategies
    {
        private IEnumerable<IDivisorStrategy> strategies;
        private long upperBound = 10;
        private IWriter writer;
        private FizzBuzzer fizzBuzzer;
        private StringBuilder stringBuilder;

        [Test]
        public void RunTest()
        {
            GivenIHaveA3and5andDefaultStragies();
            WhenIExecuteWithAnUpperBoundOf10();
            ThenMyWriterShouldWriteTheAppropriateText();
        }

        private void GivenIHaveA3and5andDefaultStragies()
        {
            strategies = new List<IDivisorStrategy>
            {
                new DivisibleBy5(),
                new DivisibleBy3(),
                new DefaultDivisorStrategy()
            };
        }

        private void WhenIExecuteWithAnUpperBoundOf10()
        {
            stringBuilder = new StringBuilder(100);
            fizzBuzzer = new FizzBuzzer(new StringBuilderWriter(stringBuilder), strategies);
            fizzBuzzer.Execute(upperBound);

        }

        private void ThenMyWriterShouldWriteTheAppropriateText()
        {
            var expectedMessage = @"1
2
Fizz
4
Buzz
Fizz
7
8
9
Buzz";
            stringBuilder.ToString().Should().Be(expectedMessage);
        }
    }
}