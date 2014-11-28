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

        public void Execute(int upperBound = 100)
        {
            for (int i = 1; i < upperBound; i++)
            {
                var message = "";

                if (i % 15 == 0) message = "Fizzuzz";
                else if (i % 3 == 0) message = "Fizz";
                else if (i % 5 == 0) message = "Buzz";
                else message = i.ToString();

                writer.WriteLine(message);
            }
        }
    }
}
