using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasure.AFA;
using ClearMeasure.AFA.DivisorStrategies;
using ClearMeasure.AFA.DivisorStrategies.Interfaces;
using ClearMeasure.AFA.Writers;

namespace ClearMeasure.Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleWriter();
            var strategies = new List<IDivisorStrategy>
            {
                new DivisibleBy3(),
                new DivisibleBy5()
            };

            var fizzer = new FizzBuzzer(writer, strategies);

            fizzer.Execute();
        }
    }
}
