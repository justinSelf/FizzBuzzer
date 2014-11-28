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
    public class Using3And5Strategies
    {
        private IEnumerable<IDivisorStrategy> strategies;
        private long upperBound;
        private IWriter writer;
        private FizzBuzzer fizzBuzzer;
        private StringBuilder stringBuilder;
        private string expectedMessage;

        [Test]
        public void RunTestWithUpperBoundof10()
        {
            GivenIHaveA3and5Stragies();
            WhenIExecuteWithAnUpperBoundOf10();
            ThenMyWriterShouldWriteTheAppropriateText();
        }

        [Test]
        public void RunTestWithUpperBoundOf16()
        {
            GivenIHaveA3and5Stragies();
            WhenIExecuteWithAnUpperBoundOf16();
            ThenMyWriterShouldWriteTheAppropriateText();
        }

        private void WhenIExecuteWithAnUpperBoundOf16()
        {
            upperBound = 16;
            stringBuilder = new StringBuilder();
            fizzBuzzer = new FizzBuzzer(new StringBuilderWriter(stringBuilder), strategies);
            fizzBuzzer.Execute(upperBound);
            expectedMessage = @"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
";
        }

        private void GivenIHaveA3and5Stragies()
        {
            strategies = new List<IDivisorStrategy>
            {
                new DivisibleBy3(),
                new DivisibleBy5()
            };
        }

        private void WhenIExecuteWithAnUpperBoundOf10()
        {
            upperBound = 10;
            stringBuilder = new StringBuilder();
            fizzBuzzer = new FizzBuzzer(new StringBuilderWriter(stringBuilder), strategies);
            fizzBuzzer.Execute(upperBound);
            expectedMessage = @"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
";
        }

        private void ThenMyWriterShouldWriteTheAppropriateText()
        {
            stringBuilder.ToString().Should().Be(expectedMessage);
        }
    }
}