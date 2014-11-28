using System;
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
    public class UsingCustomDivisors
    {
        private IEnumerable<IDivisorStrategy> strategies;
        private ulong upperBound;
        private IWriter writer;
        private FizzBuzzer fizzBuzzer;
        private StringBuilder stringBuilder;
        private string expectedMessage;

        [Test]
        public void RunTestWithUpperBoundof20()
        {
            GivenIHaveTwoCustomDivisors();
            WhenIExecuteWithAnUpperBoundOf20();
            ThenMyWriterShouldWriteTheAppropriateText();
        }

        private void WhenIExecuteWithAnUpperBoundOf20()
        {
            upperBound = 20;
            stringBuilder = new StringBuilder();
            fizzBuzzer = new FizzBuzzer(new StringBuilderWriter(stringBuilder), strategies);
            fizzBuzzer.Execute(upperBound);
            expectedMessage = @"oddWeird
even
odd
evenWeird
odd
even
oddWeird
even
odd
evenWeird
odd
even
oddWeird
even
odd
evenWeird
odd
even
oddWeird
even
";
        }

        private void GivenIHaveTwoCustomDivisors()
        {
            Func<decimal, bool> evenFactorFunction = num => num % 2 == 0;
            Func<decimal, bool> oddFactorFunction = num => num % 2 != 0;
            Func<decimal, bool> weirdFactorFunction = num => (num % 3 + 4) * 10 == 50;
            strategies = new List<IDivisorStrategy>
            {
                new CustomDivisor("even", evenFactorFunction),
                new CustomDivisor("odd", oddFactorFunction),
                new CustomDivisor("Weird", weirdFactorFunction)
            };
        }

        private void ThenMyWriterShouldWriteTheAppropriateText()
        {
            stringBuilder.ToString().Should().Be(expectedMessage);
        }
    }
}