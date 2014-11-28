namespace ClearMeasure.AFA.DivisorStrategies.Interfaces
{
    public interface IDivisorStrategy
    {
        ulong Divisor { get; }
        bool IsFactorOf(ulong number);
        string Message { get; }
    }
}