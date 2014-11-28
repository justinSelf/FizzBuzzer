using System;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public class CustomDivisor : BaseDivisorStrategy
    {
        private readonly Func<long, string> factorFunction;
        public CustomDivisor()
            : this(0, "Custom")
        {

        }

        public CustomDivisor(long divisor, string message)
            : this(divisor, message, null)
        {

        }

        public CustomDivisor(long divisor, string message, Func<long, string> factorFunc)
        {
            this.Divisor = divisor;
            this.Message = message;

            factorFunction = factorFunc ?? (num => num % Divisor == 0 ? Message : "");
        }

        public override string GetMessageForFactorOf(long number)
        {
            return factorFunction(number);
        }
    }
}