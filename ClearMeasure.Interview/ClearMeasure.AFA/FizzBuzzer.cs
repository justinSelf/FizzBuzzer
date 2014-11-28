using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasure.AFA.DivisorStrategies.Interfaces;
using ClearMeasure.AFA.Writers.Interfaces;

namespace ClearMeasure.AFA
{
    public class FizzBuzzer
    {
        private readonly IWriter writer;
        private readonly IEnumerable<IDivisorStrategy> divisorStrategies;

        public FizzBuzzer(IWriter writer, IEnumerable<IDivisorStrategy> divisorStrategies)
        {
            this.writer = writer;
            this.divisorStrategies = divisorStrategies;
        }

        public void Execute(long upperBound = 100)
        {
            for (int i = 1; i < upperBound + 1; i++)
            {
                var factors = divisorStrategies
                    .Where(strat => strat.IsFactorOf(i))
                    .Select(strat => strat.Message);

                var message = factors.Any() ? factors.Aggregate((current, next) => current + next)
                : i.ToString();

                writer.WriteLine(message);
            }
        }
    }
}
