using System;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public class CustomDivisor : BaseDivisorStrategy
    {
        private readonly Func<decimal, bool> factorFunction;
        public CustomDivisor()
            : this(0, "Custom")
        {

        }

        public CustomDivisor(decimal divisor, string message)
            : this(divisor, message, null)
        {

        }

        public CustomDivisor(decimal divisor, string message, Func<decimal, bool> factorFunc)
        {
            this.Divisor = divisor;
            this.Message = message;

            factorFunction = factorFunc ?? (num => num % Divisor == 0);
        }

        public override bool IsFactorOf(decimal number)
        {
            return factorFunction(number);
        }
    }
}