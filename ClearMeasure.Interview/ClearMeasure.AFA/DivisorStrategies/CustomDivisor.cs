using System;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public class CustomDivisor : BaseDivisorStrategy
    {
        private readonly Func<ulong, bool> factorFunction;
        public CustomDivisor()
            : this(0, "Custom")
        {

        }

        public CustomDivisor(ulong divisor, string message)
            : this(divisor, message, null)
        {

        }

        public CustomDivisor(ulong divisor, string message, Func<ulong, bool> factorFunc)
        {
            this.Divisor = divisor;
            this.Message = message;

            factorFunction = factorFunc ?? (num => num % Divisor == 0);
        }

        public override bool IsFactorOf(ulong number)
        {
            return factorFunction(number);
        }
    }
}