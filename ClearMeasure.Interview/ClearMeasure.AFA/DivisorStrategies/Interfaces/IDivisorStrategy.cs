namespace ClearMeasure.AFA.DivisorStrategies.Interfaces
{
    public interface IDivisorStrategy
    {
        long Divisor { get; }
        bool IsFactorOf(long number);
        string Message { get; }
    }
}