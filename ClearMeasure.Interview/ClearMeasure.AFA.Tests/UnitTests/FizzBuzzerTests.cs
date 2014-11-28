using System.Collections.Generic;
using System.Runtime.InteropServices;
using ClearMeasure.AFA.DivisorStrategies;
using ClearMeasure.AFA.DivisorStrategies.Interfaces;
using ClearMeasure.AFA.Writers.Interfaces;
using NUnit.Framework;
using Rhino.Mocks;

namespace ClearMeasure.AFA.Tests.UnitTests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        const int UPPERBOUND = 114;
        [Test]
        public void WriterCallCountShouldMatchUpperBound()
        {
            //Arrange
            var mockWriter = MockRepository.GenerateMock<IWriter>();
            mockWriter.Expect(writer => writer.WriteLine(Arg<string>.Is.Anything)).Repeat.Times(UPPERBOUND);

            var strategies = new List<IDivisorStrategy>();
            var fizzer = new FizzBuzzer(mockWriter, strategies);

            //Act
            fizzer.Execute(UPPERBOUND);

            //Assert
            mockWriter.VerifyAllExpectations();
        }

        [Test]
        public void StrategiesCallCountShouldMatchUpperBound()
        {
            //Arrange
            var mockDivisorStrategy = MockRepository.GenerateMock<IDivisorStrategy>();
            mockDivisorStrategy.Expect(strat => strat.IsFactorOf(Arg<long>.Is.Anything))
                .Return(true)
                .Repeat.Times(UPPERBOUND);

            var strategies = new List<IDivisorStrategy> { mockDivisorStrategy };
            var writerStub = MockRepository.GenerateStub(typeof(IWriter)) as IWriter;
            var fizzer = new FizzBuzzer(writerStub, strategies);

            //Act
            fizzer.Execute(UPPERBOUND);

            //Assert
            mockDivisorStrategy.VerifyAllExpectations();
        }
    }
}