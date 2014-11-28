using ClearMeasure.AFA.DivisorStrategies.Interfaces;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public abstract class BaseDivisorStrategy : IDivisorStrategy
    {
        public decimal Divisor { get; protected set; }
        public virtual bool IsFactorOf(decimal number)
        {
            return number % Divisor == 0;
        }

        public string Message { get; protected set; }
    }
}