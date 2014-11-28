using ClearMeasure.AFA.DivisorStrategies.Interfaces;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public abstract class BaseDivisorStrategy : IDivisorStrategy
    {
        public long Divisor { get; protected set; }
        public virtual string GetMessageForFactorOf(long number)
        {
            return number % Divisor == 0 ? Message : "";
        }

        public string Message { get; protected set; }
    }
}