using ClearMeasure.AFA.DivisorStrategies.Interfaces;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public abstract class BaseDivisorStrategy : IDivisorStrategy
    {
        public ulong Divisor { get; protected set; }
        public virtual bool IsFactorOf(ulong number)
        {
            return number % Divisor == 0;
        }

        public string Message { get; protected set; }
    }
}