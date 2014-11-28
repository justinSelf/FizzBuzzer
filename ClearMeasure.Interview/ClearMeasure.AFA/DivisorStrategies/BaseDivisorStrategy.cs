using ClearMeasure.AFA.DivisorStrategies.Interfaces;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public abstract class BaseDivisorStrategy : IDivisorStrategy
    {
        public long Divisor { get; protected set; }
        public virtual bool IsFactorOf(long number)
        {
            return number % Divisor == 0;
        }

        public string Message { get; protected set; }
    }
}