using System;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public class CustomDivisor : BaseDivisorStrategy
    {
        private readonly Func<long, bool> factorFunction;
        public CustomDivisor()
            : this(0, "Custom")
        {

        }

        public CustomDivisor(long divisor, string message)
            : this(divisor, message, null)
        {

        }

        public CustomDivisor(long divisor, string message, Func<long, bool> factorFunc)
        {
            this.Divisor = divisor;
            this.Message = message;

            factorFunction = factorFunc ?? (num => num % Divisor == 0);
        }

        public override bool IsFactorOf(long number)
        {
            return factorFunction(number);
        }
    }
}