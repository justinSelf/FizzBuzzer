using System.Collections;
using System.Collections.Generic;
using ClearMeasure.AFA.DivisorStrategies.Interfaces;
using ClearMeasure.AFA.Writers.Interfaces;
using NUnit.Framework;

namespace ClearMeasure.AFA.Tests.IntergrationTests
{
    [TestFixture]
    public class Using3And5Strategies
    {
        private IEnumerable<IDivisorStrategy> strategies;
        private long upperBound = 10;
        private IWriter writer;

        [Test]
        public void RunTest()
        {
            GivenIHaveA3and5Stragies();
            WhenIExecuteWithAnUpperBoundOf10();
            ThenMyWriterShouldWriteTheAppropriateText();
        }

        private void GivenIHaveA3and5Stragies()
        {

        }

        private void WhenIExecuteWithAnUpperBoundOf10()
        {

        }

        private void ThenMyWriterShouldWriteTheAppropriateText()
        {

        }
    }
}