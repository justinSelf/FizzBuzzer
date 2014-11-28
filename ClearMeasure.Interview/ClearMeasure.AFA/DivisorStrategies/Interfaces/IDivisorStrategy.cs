namespace ClearMeasure.AFA.DivisorStrategies.Interfaces
{
    public interface IDivisorStrategy
    {
        long Divisor { get; }
        string GetMessageForFactorOf(long number);
        string Message { get; }
    }
}